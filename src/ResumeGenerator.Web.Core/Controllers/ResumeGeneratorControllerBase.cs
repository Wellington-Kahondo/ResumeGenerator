using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ResumeGenerator.Controllers
{
    public abstract class ResumeGeneratorControllerBase: AbpController
    {
        protected ResumeGeneratorControllerBase()
        {
            LocalizationSourceName = ResumeGeneratorConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
