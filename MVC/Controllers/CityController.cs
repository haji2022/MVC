using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    //[Authorize(Roles="Admin")]
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


        public IActionResult Create()
        {
            ViewBag.City = new SelectList(_context.Languages, "City");
            return View();

        }

        


        [HttpPost]
        public IActionResult Create(City city)
        {
            ModelState.Remove("People");
            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult AddCity()
        {
            ViewBag.Countries = new SelectList(_context.Countries, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddCity(City c)
        {

            ModelState.Remove("People");
            ModelState.Remove("Country");
            if (ModelState.IsValid)
            {
                City city = new City();
                city.CountryId = c.CountryId;
                city.Name = c.Name;
                _context.Cities.Add(city);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("AddCity");


        }

        public IActionResult Edit(int id)
        {
            var city = _context.Cities.FirstOrDefault(m => m.Id == id);
            return View(city);
        }

        [HttpPost]
        public IActionResult Edit(City c, int id)
        {
            ModelState.Remove("People");
            ModelState.Remove("Country");
            if (ModelState.IsValid)
            {
                var city = _context.Cities.FirstOrDefault(m => m.Id == id);
                city.Name = c.Name;
           
                _context.Cities.Update(city);

                _context.SaveChanges();



                return RedirectToAction("Index");
            }
            return View();
        }



        public IActionResult Delete(int id)
        {


            var city = _context.Cities.FirstOrDefault(m => m.Id == id);

            return View("index");

           

        }

        [HttpPost]
        public IActionResult Delete(int cityId, int a)
        {
            var city = _context.Cities.FirstOrDefault(m => m.Id == cityId);
            _context.Cities.Remove(city);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }






    }
}