using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SummaryService.Dtos
{
    [AutoMap(typeof(Profile))]
    public class ProfileDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SectionId { get; set; }
    }
}
