using Abp.Application.Services;
using tgtDemo.Dto;
using tgtDemo.Logging.Dto;

namespace tgtDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
