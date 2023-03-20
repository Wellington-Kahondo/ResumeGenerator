using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.SectionService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.WorkExperienceService.Dtos
{
    [AutoMap(typeof(WorkExperience))]
    public class WorkExperienceDto : EntityDto<Guid>
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public Guid SectionId { get; set; }

    }
}
