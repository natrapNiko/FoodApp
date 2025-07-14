using Microsoft.AspNetCore.Mvc;

namespace FoodApp.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
