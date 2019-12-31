using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tgtDemo
{
    [DependsOn(typeof(tgtDemoXamarinSharedModule))]
    public class tgtDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoXamarinIosModule).GetAssembly());
        }
    }
}