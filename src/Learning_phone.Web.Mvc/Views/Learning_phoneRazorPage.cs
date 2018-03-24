using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Learning_phone.Web.Views
{
    public abstract class Learning_phoneRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected Learning_phoneRazorPage()
        {
            LocalizationSourceName = Learning_phoneConsts.LocalizationSourceName;
        }
    }
}
