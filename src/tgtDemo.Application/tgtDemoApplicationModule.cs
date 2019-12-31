using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using tgtDemo.Authorization;

namespace tgtDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(tgtDemoCoreModule)
        )]
    public class tgtDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoApplicationModule).GetAssembly());
        }
    }
}