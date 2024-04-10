using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;
using System.Collections.Generic;

namespace SimpleWebApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAllProducts() {
            var products = new List<Products>
            {
                new Products { Id = 1, Name="A Product", ThumbImg="https://dummyimage.com/130x100&text=example+product", Quantity = 1 },
                new Products { Id = 2, Name="B Product", ThumbImg="https://dummyimage.com/130x100&text=example+product", Quantity = 3 },
                new Products { Id = 3, Name="C Product", ThumbImg="https://dummyimage.com/130x100&text=example+product", Quantity = 5 }
            };

            Users user = new Users
            {
                Id = 1,
                Name = "Kamran",
                LastName = "Karimov"
            };

            var userProduct = (products, user);

            return View(userProduct);
        }
    }
}
