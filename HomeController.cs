using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;

namespace MyMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new MessageModel
            {
                Text = "Hello from ASP.NET Core MVC on Mac!"
            };
            return View(model);
        }
    }
}
