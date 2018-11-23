using System.Web.Mvc;

namespace LPDemo.Web.Controllers
{
    public class AboutController : LPDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}