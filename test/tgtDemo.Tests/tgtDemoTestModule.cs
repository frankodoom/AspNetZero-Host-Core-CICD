using Abp.Modules;
using tgtDemo.Test.Base;

namespace tgtDemo.Tests
{
    [DependsOn(typeof(tgtDemoTestBaseModule))]
    public class tgtDemoTestModule : AbpModule
    {
       
    }
}
