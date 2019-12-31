using Microsoft.Extensions.Configuration;

namespace tgtDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
