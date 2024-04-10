using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
