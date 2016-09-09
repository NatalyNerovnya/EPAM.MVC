using System.Web.Mvc;
using Models.Data;
using Models.Models;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRepo _repo;

        public HomeController(IPersonRepo personRepo)
        {
            _repo = personRepo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Person() { HomeAddress = new Address()});
        }

        [HttpPost]
        public ActionResult Index(Person person)
        {
            
            return View("ShowPerson", person);
        }
    }
}