using System.Threading.Tasks;
using Abp.Application.Services;
using ResumeGenerator.Authorization.Accounts.Dto;

namespace ResumeGenerator.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
