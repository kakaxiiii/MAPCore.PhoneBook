using Abp.Authorization;
using MAPCore.PhoneBook.Authorization.Roles;
using MAPCore.PhoneBook.Authorization.Users;

namespace MAPCore.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
