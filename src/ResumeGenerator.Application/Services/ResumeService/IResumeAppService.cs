using Abp.Application.Services;
using ResumeGenerator.Services.ResumeService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResumeGenerator.Services.ResumeService
{
    public interface IResumeAppService : IApplicationService
    {
        Task<ResumeDto> GetResumeById(Guid id);
        Task<List<ResumeDto>> GetAllResumes();
        Task<ResumeDto> CreateResume(ResumeInputDto input);
        Task<ResumeDto> UpdateResume(ResumeInputDto input);
        Task DeleteResume(Guid id);
    }
}
