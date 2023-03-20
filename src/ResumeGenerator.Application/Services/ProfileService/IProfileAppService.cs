using Abp.Application.Services;
using ResumeGenerator.Services.SummaryService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SummaryService
{
    public interface IProfileAppService : IAsyncCrudAppService<ProfileDto, Guid>
    {
    }
}
