using Abp.Application.Services;
using Abp.Domain.Repositories;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.EducationServices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.EducationService
{
    public class EducationAppService : AsyncCrudAppService<Education, EducationDto, Guid>, IEducationAppService
    {
        public EducationAppService(IRepository<Education, Guid> repository) : base(repository)
        {
        }
    }
}
