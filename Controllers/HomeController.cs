using Microsoft.AspNetCore.Mvc;

namespace MyCvWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Interests()
        {
            return View();
        }
    }
}
