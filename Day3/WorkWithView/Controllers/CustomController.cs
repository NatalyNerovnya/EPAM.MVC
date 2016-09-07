using System.Web.Mvc;
using WorkWithView.Infrastructure;

namespace WorkWithView.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult CustomIndex()
        {
            return View(new CustomDataView());
        }

        public ActionResult Index()
        {
            string[] fruits = { "aplle", "watermellon", "orange" };
            return View(fruits);
        }

        public ActionResult BadAction()
        {
            return View();
        }
    }
}