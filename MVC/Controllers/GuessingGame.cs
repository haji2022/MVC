using Microsoft.AspNetCore.Mvc;
using BasicMVC.Models;


namespace BasicMVC.Controllers
{
    public class GuessingGame : Controller
    {
        public IActionResult GuessGame()
        {

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("Session")))
            {
                int rand = GuessModel.GNR();
                GuessModel.GuessGamenummer = rand;
                HttpContext.Session.SetString("Session", rand.ToString());
            }
            else
            {
                GuessModel.GuessGamenummer = int.Parse(HttpContext.Session.GetString("Session"));
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