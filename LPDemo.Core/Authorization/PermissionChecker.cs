using Abp.Authorization;
using LPDemo.Authorization.Roles;
using LPDemo.Authorization.Users;

namespace LPDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
