using Microsoft.AspNetCore.Mvc;
using tgtDemo.Web.Controllers;

namespace tgtDemo.Web.Public.Controllers
{
    public class AboutController : tgtDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}