using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Learning_phone.Controllers
{
    public abstract class Learning_phoneControllerBase: AbpController
    {
        protected Learning_phoneControllerBase()
        {
            LocalizationSourceName = Learning_phoneConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
