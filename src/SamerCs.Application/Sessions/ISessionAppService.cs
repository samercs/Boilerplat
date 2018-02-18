using System.Threading.Tasks;
using Abp.Application.Services;
using SamerCs.Sessions.Dto;

namespace SamerCs.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
