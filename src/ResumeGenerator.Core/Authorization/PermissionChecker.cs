using Abp.Authorization;
using ResumeGenerator.Authorization.Roles;
using ResumeGenerator.Authorization.Users;

namespace ResumeGenerator.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
