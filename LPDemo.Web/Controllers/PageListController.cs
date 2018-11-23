using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPDemo.Web.Controllers
{
    public class PageListController : LPDemoControllerBase
    {
        // GET: PageList
        public ActionResult Index()
        {
            return View();
        }
    }
}