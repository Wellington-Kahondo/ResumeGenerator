using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain;
using ResumeGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.PersonService.Dtos
{
    [AutoMap(typeof(Person))]
    public class PersonDto : FullAuditedEntityDto<Guid>
    {
        public RefListTitle? Title { get; set; }
        public string TitleText { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName 
        {
            get
            {
                return FirstName +" "+ Surname;
            }               
        }
        public DateTime? DateOfBirth { get; set; }
        public RefListGender? Gender { get; set; }
        public string GenderText { get; set; }
        public RefListRace? Race { get; set; }
        public string RaceText { get; set; }
        public string IdentificationNumber { get; set; }
        public string CellNumber { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public bool IsAdmin { get; set; }
    }
}
