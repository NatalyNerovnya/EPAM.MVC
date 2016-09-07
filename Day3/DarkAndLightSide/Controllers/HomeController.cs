using DarkAndLightSide.Models;
using System.Web.Mvc;

namespace DarkAndLightSide.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpPost]
        public ActionResult Index(User user)
        {
            Users.UsersList.Add(new User() {
                Name = user.Name,
                Age = user.Age,
                Side = user.Side
            });
            if (user.Side == Side.Dark)
                return RedirectToAction("Index", "Dark", user);
            else
                return RedirectToAction("Index", "Light", user);
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new User());
        }
    }
}