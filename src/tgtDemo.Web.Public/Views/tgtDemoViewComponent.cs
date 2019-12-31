using Abp.AspNetCore.Mvc.ViewComponents;

namespace tgtDemo.Web.Public.Views
{
    public abstract class tgtDemoViewComponent : AbpViewComponent
    {
        protected tgtDemoViewComponent()
        {
            LocalizationSourceName = tgtDemoConsts.LocalizationSourceName;
        }
    }
}