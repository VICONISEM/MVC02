using Microsoft.AspNetCore.Mvc;

namespace MVC02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("CR");
        }


        public IActionResult CR()
        {
            return Content ("Hello from CR Action");
        }
    }
}
