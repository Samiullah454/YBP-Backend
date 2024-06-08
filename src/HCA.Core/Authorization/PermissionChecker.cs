using Abp.Authorization;
using HCA.Authorization.Roles;
using HCA.Authorization.Users;

namespace HCA.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
