using SimpleWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

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

        [HttpPost]
        public IActionResult Login(Users user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            return View();
        }


    }
}
