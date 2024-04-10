using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
