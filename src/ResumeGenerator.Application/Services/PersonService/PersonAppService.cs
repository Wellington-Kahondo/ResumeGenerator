using Abp.Authorization;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ResumeGenerator.Authorization.Roles;
using ResumeGenerator.Authorization.Users;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.Helpers;
using ResumeGenerator.Services.PersonService.Dtos;
using ResumeGenerator.Services.StoredFileService;
using ResumeGenerator.Services.StoredFileService.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResumeGenerator.Services.PersonService
{
    public class PersonAppService : ResumeGeneratorAppServiceBase
    {
        private readonly IRepository<User, long> _userRepository;
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly UserManager _userManagerRepository;

        public PersonAppService(IRepository<User, long> userRepository,
            IRepository<Person, Guid> personRepository,
            UserManager userManagerRepository)
        {
            _personRepository = personRepository;
            _userManagerRepository = userManagerRepository;
            _userRepository = userRepository;

        }

        [HttpPost]

        public async Task<PersonDto> CreatePerson([FromForm] PersonInputDto input)
        {
            if (string.IsNullOrEmpty(input.UserId.ToString()))
                throw new UserFriendlyException("User not found. Please make sure that the logged in.");

            var storedFile = new StoredFile();
            if (input.File != null)
            {
                var storedFileService = IocManager.Instance.Resolve<StoredFileAppService>();
                var storedFileDto = new StoredFileDto() { File = input.File };
                storedFile = await storedFileService.CreateStoredFile(storedFileDto);
            }

            var user = await _userRepository.GetAsync(input.UserId);

            //check if user isAdmin
            var isUSerAdmin = await _userManagerRepository.IsInRoleAsync(user, "Admin");

            var person = ObjectMapper.Map<Person>(input);
            person.FirstName = user.Name;
            person.Surname = user.Surname;
            person.EmailAddress = user.EmailAddress;
            person.User = user;
            person.IsAdmin = isUSerAdmin;
            person.StoredFile = storedFile ?? null;

            return ObjectMapper.Map<PersonDto>(
                await _personRepository.InsertAsync(person));
        }

        [HttpGet]
        public async Task<PersonDto> GetPerson(Guid id)
        {
            var person = await _personRepository.FirstOrDefaultAsync(x => x.Id == id);
            return ObjectMapper.Map<PersonDto>(person);
        }

        [HttpGet]
        public async Task<PersonDto> GetPersonByUserId(long id)
        {
            var person = await _personRepository.FirstOrDefaultAsync(x => x.User.Id == id);
            return ObjectMapper.Map<PersonDto>(person);
        }

        public async Task<List<PersonDto>> GetAll()
        {
            var persons = await _personRepository.GetAllListAsync();
            return ObjectMapper.Map<List<PersonDto>>(persons);
        }

    }
}
