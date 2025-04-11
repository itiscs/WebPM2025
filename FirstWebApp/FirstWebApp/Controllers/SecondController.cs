using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }
    }
}
