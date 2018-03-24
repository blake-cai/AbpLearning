using Abp.AspNetCore.Mvc.ViewComponents;

namespace Learning_phone.Web.Views
{
    public abstract class Learning_phoneViewComponent : AbpViewComponent
    {
        protected Learning_phoneViewComponent()
        {
            LocalizationSourceName = Learning_phoneConsts.LocalizationSourceName;
        }
    }
}
