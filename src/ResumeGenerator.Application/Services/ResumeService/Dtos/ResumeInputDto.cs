using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using ResumeGenerator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.ResumeService.Dtos
{
    [AutoMap(typeof(Resume))]
    public class ResumeInputDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PersonId { get; set; }
    }
}
