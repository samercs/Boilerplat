using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SamerCs.Controllers
{
    public abstract class SamerCsControllerBase: AbpController
    {
        protected SamerCsControllerBase()
        {
            LocalizationSourceName = SamerCsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
