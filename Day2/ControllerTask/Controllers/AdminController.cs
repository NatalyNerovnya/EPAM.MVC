using ControllerTask.Infrastructure;
using System.Web.Mvc;

namespace ControllerTask.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        [Local]
        public ActionResult Index()
        {
            return View();
        }
    }
}