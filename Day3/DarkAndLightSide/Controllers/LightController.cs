using DarkAndLightSide.Models;
using System.Web.Mvc;

namespace DarkAndLightSide.Controllers
{
    public class LightController : Controller
    {
        // GET: Light
        public ActionResult Index(User user)
        {
            return View("PersonalInfo", user);
        }

        public ActionResult ChangeSide(User user)
        {
            user.Side = Side.Dark;
            return RedirectToAction("Index", "Dark", user);
        }
    }
}