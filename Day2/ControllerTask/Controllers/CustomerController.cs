using ControllerTask.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControllerTask.Controllers
{
    public class CustomerController : BaseController
    {
        //[HttpPost]
        //[ActionName("Add-User")]
        public async Task<ActionResult> Add()
        {
            await Task.Factory.StartNew(() => UsersList.AddUserAsync());
            
            return RedirectToAction("Show");
        }
        
        //[HttpPost]
       // [ActionName("User-List")]
        public JsonResult GetJsonListOfUsers()
        {
            var users = UsersList.GetAll();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        //User-List
        [HttpGet]
        //[ActionName("User-List")]
        public ActionResult Show()
        {
            ViewBag.Users = UsersList.GetAll();
            return View();
        }
    }
}