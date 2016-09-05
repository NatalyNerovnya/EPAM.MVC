using System.Web.Mvc;
using Controllers.Models;

namespace Controllers.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "Index"
            });
        }

        public ActionResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "List"
            });
        }
    }
}