using Abp.Application.Services;
using Abp.Domain.Repositories;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.WorkExperienceService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.WorkExperienceService
{
    public class WorkExperienceAppService : AsyncCrudAppService<WorkExperience, WorkExperienceDto, Guid>, IWorkExperienceAppService
    {
        public WorkExperienceAppService(IRepository<WorkExperience, Guid> repository) : base(repository)
        {
        }
    }
}
