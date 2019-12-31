using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tgtDemo.Startup
{
    [DependsOn(typeof(tgtDemoCoreModule))]
    public class tgtDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}