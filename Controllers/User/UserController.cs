using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers.User
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


    }
}
