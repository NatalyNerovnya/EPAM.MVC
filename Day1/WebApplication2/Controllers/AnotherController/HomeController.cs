using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers.AnotherController
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string str = "Another Controller")
        {
            return Json(str, JsonRequestBehavior.AllowGet);
        }
    }
}