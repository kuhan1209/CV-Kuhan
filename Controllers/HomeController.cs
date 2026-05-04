using Microsoft.AspNetCore.Mvc;

namespace MyCvWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Interests");
        }

        public IActionResult Interests()
        {
            return View();
        }
    }
}
