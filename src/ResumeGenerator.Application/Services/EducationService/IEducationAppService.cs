using Abp.Application.Services;
using ResumeGenerator.Services.EducationServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.EducationService
{
    public interface IEducationAppService : IAsyncCrudAppService<EducationDto, Guid>
    {
    }
}
