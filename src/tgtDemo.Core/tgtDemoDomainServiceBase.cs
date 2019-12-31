using Abp.Domain.Services;

namespace tgtDemo
{
    public abstract class tgtDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected tgtDemoDomainServiceBase()
        {
            LocalizationSourceName = tgtDemoConsts.LocalizationSourceName;
        }
    }
}
