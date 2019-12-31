using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using tgtDemo.Authorization.Users.Dto;

namespace tgtDemo.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
