using SimpleWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace SimpleWebApp.Controllers.User
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var users = new List<Users>
            {
                new Users { Name = "Kamran", LastName="Karimov", Email="kamran@example.ex"},
                new Users { Name = "Samir", LastName="Agazadeh", Email="samir@example.ex"},
                new Users { Name = "Elxan", LastName="Zeynalli", Email="elxan@example.ex"}
            };

            return View(users);
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

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Users user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            return View();
        }


    }
}
