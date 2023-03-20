using System.Threading.Tasks;
using Abp.Application.Services;
using ResumeGenerator.Sessions.Dto;

namespace ResumeGenerator.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
