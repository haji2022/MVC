using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class CityController : Controller
    {




        readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context) 
        {
            _context = context; 
        }
        public IActionResult Index()
        {
            List<City> cities = _context.Cities.ToList();

            return View(cities);
        }






        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
