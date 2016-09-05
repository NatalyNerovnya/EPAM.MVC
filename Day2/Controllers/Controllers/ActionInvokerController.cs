using System.Web.Mvc;
using Controllers.Infrastructure;

namespace Controllers.Controllers
{
    public class ActionInvokerController : Controller
    {
        // GET: ActionInvoker
        public ActionInvokerController()
        {
            this.ActionInvoker = new CustomActionInvoker();
        }
    }
}