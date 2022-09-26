using Microsoft.AspNetCore.Mvc;

using MVC.Data;
using MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MVC.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class CountryController : Controller
    {


        readonly ApplicationDbContext _context;
        public CountryController(ApplicationDbContext context) 
        {
            _context = context; 
        }


        public IActionResult Index()
        {
            List<Country> countries = _context.Countries.ToList();

            return View(countries);
        }

        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(_context.Countries, "Country");
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



        public IActionResult AddCountry()
        {
            ViewBag.Countries = new SelectList(_context.Countries, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult AddCountry(Country c)
        {

            ModelState.Remove("People");
            ModelState.Remove("Country");
            if (ModelState.IsValid)
            {
                Country country = new Country();

                country.Name = c.Name;
                _context.Countries.Add(country);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("AddCountry");


        }

        public IActionResult Edit(int id)
        {
            var country = _context.Countries.FirstOrDefault(m => m.Id == id);
            return View(country);
        }

        [HttpPost]
        public IActionResult Edit(Country c, int id)
        {
            ModelState.Remove("People");
            ModelState.Remove("Country");
            if (ModelState.IsValid)
            {
                var country = _context.Countries.FirstOrDefault(m => m.Id == id);
                country.Name = c.Name;
               
                _context.Countries.Update(country);

                _context.SaveChanges();


                return RedirectToAction("Index");
            }
            return View();
        }




        public IActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                var country = _context.Countries.FirstOrDefault(m => m.Id == id);

                return View(country);
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Delete(Country c, int cId)
        {
            var country = _context.Countries.FirstOrDefault(m => m.Id == cId);
            _context.Countries.Remove(country);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}