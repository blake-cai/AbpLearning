using Abp.Authorization;
using Learning_phone.Authorization.Roles;
using Learning_phone.Authorization.Users;

namespace Learning_phone.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
