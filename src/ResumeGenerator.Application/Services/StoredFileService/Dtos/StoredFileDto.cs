using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using ResumeGenerator.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.StoredFileService.Dtos
{
    [AutoMap(typeof(StoredFile))]
    public class StoredFileDto : EntityDto<Guid?>
    {
        public IFormFile File { get; set; }
    }
}
