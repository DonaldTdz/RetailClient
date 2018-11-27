using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HC.RetailClient.Controllers
{
    public abstract class RetailClientControllerBase: AbpController
    {
        protected RetailClientControllerBase()
        {
            LocalizationSourceName = RetailClientConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
