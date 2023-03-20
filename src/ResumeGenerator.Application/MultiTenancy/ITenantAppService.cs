using Abp.Application.Services;
using ResumeGenerator.MultiTenancy.Dto;

namespace ResumeGenerator.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

