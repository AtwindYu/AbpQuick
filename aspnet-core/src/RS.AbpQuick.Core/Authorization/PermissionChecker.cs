using Abp.Authorization;
using RS.AbpQuick.Authorization.Roles;
using RS.AbpQuick.Authorization.Users;

namespace RS.AbpQuick.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
