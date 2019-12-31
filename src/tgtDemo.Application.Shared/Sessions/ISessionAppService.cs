using System.Threading.Tasks;
using Abp.Application.Services;
using tgtDemo.Sessions.Dto;

namespace tgtDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
