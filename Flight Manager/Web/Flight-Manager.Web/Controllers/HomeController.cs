using Microsoft.AspNetCore.Mvc;

namespace Flight_Manager.Web.Controllers
{
    public class HomeController : Controller
    { 

        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
