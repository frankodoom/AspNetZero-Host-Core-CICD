using System.Threading.Tasks;
using Abp.Application.Services;
using tgtDemo.Configuration.Host.Dto;

namespace tgtDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
