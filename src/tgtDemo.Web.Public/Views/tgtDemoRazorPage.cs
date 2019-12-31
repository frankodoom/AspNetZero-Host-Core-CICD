using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace tgtDemo.Web.Public.Views
{
    public abstract class tgtDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected tgtDemoRazorPage()
        {
            LocalizationSourceName = tgtDemoConsts.LocalizationSourceName;
        }
    }
}
