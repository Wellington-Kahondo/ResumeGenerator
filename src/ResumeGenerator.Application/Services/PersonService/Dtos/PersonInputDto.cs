using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Microsoft.AspNetCore.Http;
using ResumeGenerator.Domain;
using ResumeGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.PersonService.Dtos
{
    [AutoMap(typeof(Person))]
    public class PersonInputDto 
    {
        public RefListTitle? Title { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public RefListGender? Gender { get; set; }
        public RefListRace? Race { get; set; }
        public string IdentificationNumber { get; set; }
        public string CellNumber { get; set; }
        public string Address { get; set; }
        public long UserId { get; set; }
        public IFormFile File { get; set; }
    }
}
