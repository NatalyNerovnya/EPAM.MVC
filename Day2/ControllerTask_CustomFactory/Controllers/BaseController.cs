using System;
using System.Web.Mvc;

namespace ControllerTask_CustomFactory.Controllers
{
    public class BaseController : Controller
    {
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