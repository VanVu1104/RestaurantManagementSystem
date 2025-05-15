using Microsoft.AspNetCore.Mvc;

namespace PizzaOrdering.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
