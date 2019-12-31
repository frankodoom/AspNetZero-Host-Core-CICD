using System.Threading.Tasks;
using Abp.Application.Services;
using tgtDemo.Configuration.Tenants.Dto;

namespace tgtDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
