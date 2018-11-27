using Abp.Authorization;
using HC.RetailClient.Authorization.Roles;
using HC.RetailClient.Authorization.Users;

namespace HC.RetailClient.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
