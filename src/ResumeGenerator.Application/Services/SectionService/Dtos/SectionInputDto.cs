using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ResumeGenerator.Domain;
using ResumeGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SectionService.Dtos
{
    [AutoMap(typeof(Section))]
    public class SectionInputDto :EntityDto<Guid>
    {
        public RefListSection Title { get; set; }
        public Guid ResumeId { get; set; }
    }
}
