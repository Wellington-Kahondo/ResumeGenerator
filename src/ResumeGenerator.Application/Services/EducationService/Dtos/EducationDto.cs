using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using ResumeGenerator.Domain;
using Abp.Application.Services.Dto;
using ResumeGenerator.Services.SectionService.Dtos;

namespace ResumeGenerator.Services.EducationServices.Dtos
{
    [AutoMap(typeof(Education))]
    public class EducationDto : EntityDto<Guid>
    {
        public string Degree { get; set; }
        public string SchoolName { get; set; }
        public DateTime GraduationDate { get; set; }
        public string Major { get; set; }
        public string Description { get; set; }
        public Guid SectionId { get; set; }

    }
}
