using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tgtDemo
{
    [DependsOn(typeof(tgtDemoXamarinSharedModule))]
    public class tgtDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoXamarinAndroidModule).GetAssembly());
        }
    }
}