using System.Web.Mvc;
using Controllers.Models;

namespace Controllers.Controllers
{
    public class RemoteDataController : Controller
    {
        // GET: RemoteData
        public ActionResult Data()
        {
            RemoteService service = new RemoteService();
            string data = service.GetRemoteDataAsync();
            return View((object)data);
        }
    }
}