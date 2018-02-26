using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace RS.AbpQuick.Controllers
{
    public abstract class AbpQuickControllerBase: AbpController
    {
        protected AbpQuickControllerBase()
        {
            LocalizationSourceName = AbpQuickConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
