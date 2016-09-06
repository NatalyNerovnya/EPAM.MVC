using ControllerTask.Models;
using System.Web.Mvc;
using System.Web.SessionState;

namespace ControllerTask.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("SomeData", new SomeData() {
                ControllerName = "Home",
                ActionName = "Index"
            });
        }
    }
}