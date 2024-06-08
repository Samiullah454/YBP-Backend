using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HCA.Controllers
{
    public abstract class HCAControllerBase: AbpController
    {
        protected HCAControllerBase()
        {
            LocalizationSourceName = HCAConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
