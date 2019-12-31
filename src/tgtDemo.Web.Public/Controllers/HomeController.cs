using Microsoft.AspNetCore.Mvc;
using tgtDemo.Web.Controllers;

namespace tgtDemo.Web.Public.Controllers
{
    public class HomeController : tgtDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}