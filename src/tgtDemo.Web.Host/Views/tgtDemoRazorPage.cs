using Abp.AspNetCore.Mvc.Views;

namespace tgtDemo.Web.Views
{
    public abstract class tgtDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected tgtDemoRazorPage()
        {
            LocalizationSourceName = tgtDemoConsts.LocalizationSourceName;
        }
    }
}
