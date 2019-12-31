﻿using Abp.Modules;
using Abp.Reflection.Extensions;

namespace tgtDemo
{
    public class tgtDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(tgtDemoClientModule).GetAssembly());
        }
    }
}
