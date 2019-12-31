using Abp.Authorization;
using tgtDemo.Authorization.Roles;
using tgtDemo.Authorization.Users;

namespace tgtDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
