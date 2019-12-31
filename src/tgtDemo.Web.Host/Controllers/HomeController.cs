using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace tgtDemo.Web.Controllers
{
    public class HomeController : tgtDemoControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Ui");
        }
    }
}
