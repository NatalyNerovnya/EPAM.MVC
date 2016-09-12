using System.Web.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new Voucher());
        }

		[HttpPost]
	    public ActionResult Index(Voucher model)
	    {
            ValidateVoucherModel(model);
            ValidateName(model.Name);
		    return View("Submited", model);
	    }

        public JsonResult ValidateName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return Json("Please, enter a valid name.", JsonRequestBehavior.AllowGet);
            }
            if(name.Length > 4)
            {
                return Json("Name should contain less then 50 symblos.", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }


        private void ValidateVoucherModel(Voucher model)
        {
            const string lengthError = "Please enter: {0} with length less then {1} symbls.";

            if (string.IsNullOrWhiteSpace(model.Name))
            {
                ModelState.AddModelError("Name", "Please enter voucher name");
            }
            else if (model.Name.Length > 50)
            {
                ModelState.AddModelError("Name", string.Format(lengthError, "Voucher Name", 50));
            }

        }
    }
}