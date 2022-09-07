using Microsoft.AspNetCore.Mvc;
using BasicMVC.Models;


namespace BasicMVC.Controllers
{
    public class GuessingGame : Controller
    {
        public HttpContext GetHttpContext()
        {
            return HttpContext;
        }

        public IActionResult GuessGame(HttpContext httpContext)
        {

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("Session")))
            {
                int rand = GuessModel.GNR();
                GuessModel.GuessGamenummer = rand;
                HttpContext.Session.SetString("Session", rand.ToString());
            }
            else
            {
#pragma warning disable CS8604 // Possible null reference argument.
                GuessModel.GuessGamenummer = int.Parse(httpContext.Session.GetString("Session"));
#pragma warning restore CS8604 // Possible null reference argument.
            }
            return View();
        }

    

        [HttpPost]
        public IActionResult GuessGame(int nummer)
        {

            if (nummer > 100 || nummer < 1)
            {
                ViewBag.Message = "Is not a valid number";
            }
            else
            {
                ViewBag.Message = GuessModel.GuessGame(nummer);
                ViewBag.Count = GuessModel.Count;

            }
            return View();
        }
    }
}