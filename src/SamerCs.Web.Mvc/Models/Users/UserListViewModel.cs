using System.Collections.Generic;
using SamerCs.Roles.Dto;
using SamerCs.Users.Dto;

namespace SamerCs.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
