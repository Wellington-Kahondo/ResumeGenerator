using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.SectionService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.CertificationService.Dtos
{
    [AutoMap(typeof(Certification))]
    public class CertificationDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime CertificationDate { get; set; }
        public string Description { get; set; }
        public Guid SectionId { get; set; }
    }
}
