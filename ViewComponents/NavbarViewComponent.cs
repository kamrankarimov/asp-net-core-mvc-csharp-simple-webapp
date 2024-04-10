using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;
using System.Collections.Generic;

namespace SimpleWebApp.ViewComponents
{
    public class NavbarViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //Demo Data 
            List<Navbar> navbar = new List<Navbar> {
                new Navbar { Name = "Home", ControllerName = "home", ActionName = "index"},
                new Navbar { Name = "User List", ControllerName = "user", ActionName = "index"},
                new Navbar { Name = "Product List", ControllerName = "product", ActionName = "getallproducts"},
                new Navbar { Name = "Login", ControllerName = "user", ActionName = "login"},
                new Navbar { Name = "Register", ControllerName = "user", ActionName = "register"}
            };

            return View(navbar);
        }
    }
}
