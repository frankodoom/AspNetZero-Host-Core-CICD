using System.Threading.Tasks;
using Abp.Application.Services;
using tgtDemo.Install.Dto;

namespace tgtDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}