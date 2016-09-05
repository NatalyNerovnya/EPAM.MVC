using System.Web.Mvc;
using Controllers.Models;
using Controllers.Infrastructure;

namespace Controllers.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "ProductController",
                ActionName = "Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "ProductController",
                ActionName = "Index"
            });
        }

        public ActionResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "ProductController",
                ActionName = "List"
            });
        }
    }
}