using Microsoft.AspNetCore.Mvc;
using System;

namespace SimpleWebApp.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadMore()
        {
            if (Request.RouteValues.ContainsKey("id") && Request.RouteValues.ContainsKey("category"))
            {
                var id = int.Parse((string)Request.RouteValues["id"]) ;
                string category = Request.RouteValues["category"].ToString();

                return Ok($"ID: {id} - Category: {category}");
            }
            else
            {
                return BadRequest("Params wrong");
            }
        }

    }
}
