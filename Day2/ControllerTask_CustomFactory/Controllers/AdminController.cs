using System.Web.Mvc;
using ControllerTask_CustomFactory.Models;

namespace ControllerTask_CustomFactory.Controllers
{
    public class AdminController : BaseController
    {
        // GET: Admin
        public ActionResult Delete()
        {
            var users = UsersList.GetAll();
            users?.RemoveAt(users.FindLastIndex(u => u.Name == "Unknown"));
            return RedirectToAction("User-List", "Customer");
        }
    }
}