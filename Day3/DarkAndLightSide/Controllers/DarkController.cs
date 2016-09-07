using DarkAndLightSide.Models;
using System.Web.Mvc;

namespace DarkAndLightSide.Controllers
{
    public class DarkController : Controller
    {
        // GET: Dark
        public ActionResult Index(User user)
        {
            return View(user);
        }

        public ActionResult ChangeSide(User user)
        {
            return View();
        }
    }
}