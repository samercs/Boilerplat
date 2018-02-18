using System.Threading.Tasks;
using Abp.Application.Services;
using SamerCs.Authorization.Accounts.Dto;

namespace SamerCs.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
