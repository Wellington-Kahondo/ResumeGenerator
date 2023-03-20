using Abp.Application.Services;
using Abp.Domain.Repositories;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.CertificationService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.CertificationService
{
    public class CertificationAppService : AsyncCrudAppService<Certification, CertificationDto, Guid>, ICertificationAppService
    {
        public CertificationAppService(IRepository<Certification, Guid> repository) : base(repository)
        {
        }
    }
}
