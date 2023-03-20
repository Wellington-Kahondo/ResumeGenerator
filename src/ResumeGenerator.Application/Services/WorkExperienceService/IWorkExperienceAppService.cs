using Abp.Application.Services;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.WorkExperienceService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.WorkExperienceService
{
    public interface IWorkExperienceAppService : IAsyncCrudAppService<WorkExperienceDto, Guid>
    {
    }
}
