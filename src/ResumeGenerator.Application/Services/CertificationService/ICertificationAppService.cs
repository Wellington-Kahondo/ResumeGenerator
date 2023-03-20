using Abp.Application.Services;
using ResumeGenerator.Services.CertificationService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.CertificationService
{
    public interface ICertificationAppService : IAsyncCrudAppService<CertificationDto, Guid>
    {
    }
}
