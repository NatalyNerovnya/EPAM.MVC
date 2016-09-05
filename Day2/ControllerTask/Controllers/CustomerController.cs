using ControllerTask.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControllerTask.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
       // [HttpPost]
        public async Task<ActionResult> Add()
        {
            var users = await Task<List<ControllerTask.Models.User>>.Factory.StartNew(() => UsersList.AddUserAsync();)
            
            return RedirectToAction("Show");
        }

        [HttpPost]
        public ActionResult GetJsonListIfUsers()
        {
            var users = UsersList.GetAll();
            return Json(users);
        }

        [HttpGet]
        public ActionResult Show()
        {
            return View();
        }
    }
}