using System.Linq;
using System.Web.Caching;
using ControllerTask.Infrastructure;
using System.Web.Mvc;
using ControllerTask.Models;

namespace ControllerTask.Controllers
{
    public class AdminController : BaseController
    {
        // GET: Admin
        [Local]
        public ActionResult Delete()
        {
            var users = UsersList.GetAll();
            UsersList.GetAll()?.RemoveAt(users.FindLastIndex(u => u.Name == "User"));
            return RedirectToAction("User-List","Customer");
        }
    }
}