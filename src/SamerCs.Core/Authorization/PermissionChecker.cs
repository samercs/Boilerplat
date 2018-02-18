using Abp.Authorization;
using SamerCs.Authorization.Roles;
using SamerCs.Authorization.Users;

namespace SamerCs.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
