using Abp.Application.Services;
using ResumeGenerator.Services.SkillService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SkillService
{
    public interface ISkillAppService : IAsyncCrudAppService<SkillDto, Guid>
    {
    }
}
