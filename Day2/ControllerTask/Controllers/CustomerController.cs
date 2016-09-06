using ControllerTask.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControllerTask.Controllers
{
    public class CustomerController : BaseController
    {
        // GET: Customer
        //Add-User
        //[HttpPost]
        public async Task<ActionResult> Add()
        {
            await Task.Factory.StartNew(() => UsersList.AddUserAsync());
            
            return RedirectToAction("Show");
        }

        //User-List
        //[HttpPost]
        public ActionResult GetJsonListOfUsers()
        {
            var users = UsersList.GetAll();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        //User-List
        [HttpGet]
        public ActionResult Show()
        {
            ViewBag.Users = UsersList.GetAll();
            return View();
        }
    }
}