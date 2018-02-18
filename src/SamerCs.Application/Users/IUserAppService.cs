using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamerCs.Roles.Dto;
using SamerCs.Users.Dto;

namespace SamerCs.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
