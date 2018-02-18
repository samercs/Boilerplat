using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamerCs.MultiTenancy.Dto;

namespace SamerCs.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
