using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace BasicMVC.Controllers
{  

    public class People2Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public People2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var applicationDbContext = _context.People.Include(p => p.City).Include(l => l.Languages);
            return View(applicationDbContext);
        }

        public IActionResult Details(int id)
        {
            var person = _context.People
                .Include(p => p.City)
                .FirstOrDefault(m => m.Id == id);
            return View(person);
        }

        public IActionResult Create()
        {
            
            ViewBag.CityNames = new SelectList(_context.Cities, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {

            ModelState.Remove("City");
            ModelState.Remove("Languages"); 
            if (ModelState.IsValid)
            {
                
                _context.Add(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityNames = new SelectList(_context.Cities, "Id", "Name", person.CityId);
            return View(person);
        }

        public IActionResult Edit(int id)
        {
            var person = _context.People.FirstOrDefault(m => m.Id == id);
            ViewBag.CityNames = new SelectList(_context.Cities, "Id", "Name");

            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(int id, Person perModel)
        {
            ModelState.Remove("City");
            ModelState.Remove("id");
            ModelState.Remove("Languages");
            var person = _context.People.FirstOrDefault(m => m.Id == id);
            if (ModelState.IsValid)
            {
                person.Name = perModel.Name;
                person.Phone = perModel.Phone;
                person.CityId = perModel.CityId;

                _context.Update(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityNames = new SelectList(_context.Cities, "Id", "Name");
            return View(person);
        }



        public IActionResult Delete(int id)
        {

            if (ModelState.IsValid)
            {
                var person = _context.People
            .Include(p => p.City)
            .FirstOrDefault(m => m.Id == id);

                return View(person);
            }
            return RedirectToAction("Index");

        }

        [HttpPost]
        public IActionResult Delete(Person p, int pId)
        {
            var person = _context.People.FirstOrDefault(m => m.Id == pId);
            _context.People.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
