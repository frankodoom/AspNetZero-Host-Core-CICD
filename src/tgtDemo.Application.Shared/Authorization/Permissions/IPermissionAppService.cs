using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tgtDemo.Authorization.Permissions.Dto;

namespace tgtDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
