using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.PersonService.Dtos;
using ResumeGenerator.Services.ResumeService.Dtos;
using ResumeGenerator.Services.SectionService.Dtos;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ResumeGenerator.Services.ResumeService
{
    public class ResumeAppService : ResumeGeneratorAppServiceBase , IResumeAppService
    {
        private readonly IRepository<Resume, Guid> _resumeRepository; 

        public ResumeAppService(IRepository<Resume, Guid> resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        public async Task<ResumeDto> GetResumeById(Guid id)
        {
            var resume = await _resumeRepository
                     .GetAllIncluding(x => x.Sections)
                     .Include(x => x.Sections)
                     .ThenInclude(x => x.Educations)
                     .Include(x => x.Sections)
                     .ThenInclude(x => x.Certifications)
                     .Include(x => x.Sections)
                     .ThenInclude(x => x.WorkExperiences)
                     .FirstOrDefaultAsync(x => x.Id == id);


            var resumeModel = ObjectMapper.Map<ResumeDto>(resume);
            //resumeModel.Sections = ObjectMapper.Map<List<SectionDto>>(resume.Sections);
            resumeModel.Person = ObjectMapper.Map<PersonDto>(resume.Person);

            return resumeModel;
        }

        public async Task<ResumeDto> CreateResume(ResumeInputDto input)
        {
            //validation
            if (input.PersonId == Guid.Empty)
                throw new UserFriendlyException("User not found. Please make sure you are logged in.");
            if (string.IsNullOrEmpty(input.Name))
                throw new UserFriendlyException("Please provide a name for you Resume");

            var resume = ObjectMapper.Map<Resume>(input);
            resume = await _resumeRepository.InsertAsync(resume);

            return ObjectMapper.Map<ResumeDto>(resume); 
        }
        public async Task<List<ResumeDto>> GetAllResumes()
        {

            try
            {
                var resumes = await _resumeRepository
                        .GetAllIncluding(x => x.Sections, x =>x.Person)
                        .Include(x =>x.Profile)
                        .Include(x => x.Sections)
                        .ThenInclude(x => x.Educations)
                        .Include(x => x.Sections)
                        .ThenInclude(x => x.Certifications)
                        .Include(x => x.Sections)
                        .ThenInclude(x => x.WorkExperiences)
                        .ToListAsync();
                return ObjectMapper.Map<List<ResumeDto>>(resumes);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           // return null;
            
           
        }

        //public async Task<ResumeDto> GetResume(Guid id)
        //{
        //    //var resume = await _resumeRepository.GetAsync(id);
        //    var resume = await _resumeRepository
        //        .GetAllIncluding(x => x.Sections)
        //         .Include(x => x.Sections)
        //         .ThenInclude(x => x.Educations)
        //         .Include(x => x.Sections)
        //         .ThenInclude(x => x.Certifications)
        //         .Include(x => x.Sections)
        //         .ThenInclude(x => x.WorkExperiences)
        //         .FirstOrDefaultAsync(x => x.Id ==id);

        //    return ObjectMapper.Map<ResumeDto>(resume);
        //}

        public async Task<ResumeDto> UpdateResume(ResumeInputDto input)
        {
            var resume = await _resumeRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, resume);
            resume = await _resumeRepository.UpdateAsync(resume);
            return ObjectMapper.Map<ResumeDto>(resume);
        }

        public async Task DeleteResume(Guid id)
        {
            await _resumeRepository.DeleteAsync(id);
        }
    }
}
