using Abp.Application.Services;
using Abp.Domain.Repositories;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.SkillService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SkillService
{
    public class SkillAppService : AsyncCrudAppService<Skill, SkillDto, Guid>, ISkillAppService
    {
        public SkillAppService(IRepository<Skill, Guid> repository) : base(repository)
        {
        }
    }
}
