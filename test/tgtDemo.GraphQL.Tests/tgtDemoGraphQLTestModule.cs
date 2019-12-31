using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using tgtDemo.Configure;
using tgtDemo.Startup;
using tgtDemo.Test.Base;

namespace tgtDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(tgtDemoGraphQLModule),
        typeof(tgtDemoTestBaseModule))]
    public class tgtDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoGraphQLTestModule).GetAssembly());
        }
    }
}