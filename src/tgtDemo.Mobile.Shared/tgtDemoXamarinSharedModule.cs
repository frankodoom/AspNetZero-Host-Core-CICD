using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tgtDemo
{
    [DependsOn(typeof(tgtDemoClientModule), typeof(AbpAutoMapperModule))]
    public class tgtDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoXamarinSharedModule).GetAssembly());
        }
    }
}