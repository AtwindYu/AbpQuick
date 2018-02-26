using Abp.AspNetCore.Mvc.ViewComponents;

namespace RS.AbpQuick.Web.Views
{
    public abstract class AbpQuickViewComponent : AbpViewComponent
    {
        protected AbpQuickViewComponent()
        {
            LocalizationSourceName = AbpQuickConsts.LocalizationSourceName;
        }
    }
}
