using Microsoft.AspNetCore.Mvc;

namespace JokeApp.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
