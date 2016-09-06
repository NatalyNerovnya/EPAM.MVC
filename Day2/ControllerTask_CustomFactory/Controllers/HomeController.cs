using ControllerTask_CustomFactory.Models;
using System.Web.Mvc;

namespace ControllerTask_CustomFactory.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View("SomeData", new SomeData()
            {
                ControllerName = "Home",
                ActionName = "Index"
            });
        }
    }
}