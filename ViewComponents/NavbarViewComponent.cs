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
                new Navbar { Name = "Home", ControllerName = "Home", ActionName = "Index"},
                new Navbar { Name = "Login", ControllerName = "User", ActionName = "Login"},
                new Navbar { Name = "Register", ControllerName = "User", ActionName = "Register"}
            };

            return View(navbar);
        }
    }
}
