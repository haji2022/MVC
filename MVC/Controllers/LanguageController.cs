using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
