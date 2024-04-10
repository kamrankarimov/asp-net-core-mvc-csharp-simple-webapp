using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Models;
using System.Collections.Generic;

namespace SimpleWebApp.ViewComponents
{
    public class HomeBlogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //Demo Data Blog 
            List<Blog> blog = new List<Blog> {
                new Blog { 
                    Id = 1, 
                    Title = "Test Blog 1", 
                    Text = "Donec id elit non mi porta gravida at eget metus. Donec sed odio dui.",
                    Controller = "blog",
                    Action = "ReadMore",
                    Category = "article"
                },

                new Blog {
                    Id = 2,
                    Title = "Test Blog 2",
                    Text = "Donec id elit non mi porta gravida at eget metus. Donec sed odio dui.",
                    Controller = "blog",
                    Action = "ReadMore",
                    Category = "article"
                },

                new Blog {
                    Id = 3,
                    Title = "Test Blog 3",
                    Text = "Donec id elit non mi porta gravida at eget metus. Donec sed odio dui.",
                    Controller = "blog",
                    Action = "ReadMore",
                    Category = "article"
                }
            };

            return View(blog);
        }
    }
}
