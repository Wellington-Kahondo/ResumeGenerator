using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SkillService.Dtos
{
    [AutoMap(typeof(Skill))]
    public class SkillDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int ProficiencyLevel { get; set; }
        public string Description { get; set; }
        public Guid SectionId { get; set; }
    }
}
