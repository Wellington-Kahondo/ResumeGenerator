using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace ResumeGenerator.Authorization
{
    public class ResumeGeneratorAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            var administration = context.CreatePermission("Administration");

            var userManagement = administration.CreateChildPermission("Administration.UserManagement");
            userManagement.CreateChildPermission("Administration.UserManagement.CreateUser");

             administration.CreateChildPermission("Administration.RoleManagement");
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ResumeGeneratorConsts.LocalizationSourceName);
        }
    }
}
