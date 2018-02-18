using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamerCs.Roles.Dto;

namespace SamerCs.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
