using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult CheckTemprature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckTemprature(int temp)
        {
            ViewBag.M = CheckFeverModel.CheckifTempIsOk(temp);
            return View();
        }
    }
}
