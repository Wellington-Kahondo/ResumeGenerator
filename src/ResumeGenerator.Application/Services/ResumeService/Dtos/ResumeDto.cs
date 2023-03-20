using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.PersonService.Dtos;
using ResumeGenerator.Services.SectionService.Dtos;
using ResumeGenerator.Services.StoredFileService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.ResumeService.Dtos
{
    [AutoMap(typeof(Resume))]
    public class ResumeDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid PersonId { get; set; }
        public PersonDto Person { get; set; }
        public List<SectionDto> Sections { get; set; }
        public StoredFileDto StoredFile { get; set; }
    }
}
