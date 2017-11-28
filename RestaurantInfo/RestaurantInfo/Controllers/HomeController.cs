using Microsoft.AspNetCore.Mvc;
using RestaurantInfo.Models;

namespace RestaurantInfo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "Fat Hoe Burgers" };

            return View(model);
        }
    }
}
