using Abp.AspNetCore.Mvc.Authorization;
using tgtDemo.Authorization;
using tgtDemo.Storage;
using Abp.BackgroundJobs;

namespace tgtDemo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}