using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace LPDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : LPDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}