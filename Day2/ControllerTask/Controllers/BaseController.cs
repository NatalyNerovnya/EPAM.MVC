using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerTask.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base

        protected override void HandleUnknownAction(string actionName)
        {
            try
            {
                this.View(actionName).ExecuteResult(this.ControllerContext);
            }
            catch (InvalidOperationException ieox)
            {
                this.View("ErrorPage").ExecuteResult(this.ControllerContext);
            }
        }
    }
}