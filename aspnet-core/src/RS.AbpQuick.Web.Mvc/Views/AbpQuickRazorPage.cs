using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace RS.AbpQuick.Web.Views
{
    public abstract class AbpQuickRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpQuickRazorPage()
        {
            LocalizationSourceName = AbpQuickConsts.LocalizationSourceName;
        }
    }
}
