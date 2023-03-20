using Abp.Application.Services;
using Abp.Domain.Repositories;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.SummaryService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SummaryService
{
    public class ProfileAppService : AsyncCrudAppService<Profile, ProfileDto, Guid>, IProfileAppService
    {
        public ProfileAppService(IRepository<Profile, Guid> repository) : base(repository)
        {
        }
    }
}
