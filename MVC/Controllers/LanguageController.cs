using MVC.Data;
using MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVC.Controllers
{
    
    public class LanguageController : Controller
    {

        readonly ApplicationDbContext _context;
        public LanguageController(ApplicationDbContext context) 
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Language> language = _context.Languages.ToList();

            return View(language);
        }

        public IActionResult Create()
        {
            ViewBag.Languages = new SelectList(_context.Languages, "Language");
            return View();
        }



        [HttpPost]
        public IActionResult Create(Language language)
        {
            ModelState.Remove("People");
            if (ModelState.IsValid)
            {
                _context.Languages.Add(language);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }





        [HttpPost]
        public IActionResult AddLanguage(Language lang)
        {
            if (ModelState.IsValid)
            {
                Language ss = new();
               
                ss.Name = lang.Name;

                
                _context.Languages.Add(ss);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var language = _context.Languages.FirstOrDefault(m => m.LangId == id);
            return View(language);
        }

        [HttpPost]
        public IActionResult Edit(Language lang, int id)
        {
            if (ModelState.IsValid)
            {
                var language = _context.Languages.FirstOrDefault(m => m.LangId == id);
                language.Name = lang.Name;
                
                _context.Languages.Update(language);

                _context.SaveChanges();



                return RedirectToAction("Index");
            }
            return View();
        }






        public IActionResult Delete(int id)
        {


            var lang = _context.Languages.FirstOrDefault(m => m.LangId == id);

            return View(lang);

       

        }

        [HttpPost]
        public IActionResult Delete(int langId, int a)
        {
            var lang = _context.Languages.FirstOrDefault(m => m.LangId == langId);
            _context.Languages.Remove(lang);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }





























        //public IActionResult Delete(int id)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var person = _context.People
        //    .Include(p => p.City)
        //    .FirstOrDefault(m => m.Id == id);

        //        return View(person);
        //    }
        //    return RedirectToAction("Index");

        //}

        //[HttpPost]
        //public IActionResult Delete(Person p, int pId)
        //{
        //    var person = _context.People.FirstOrDefault(m => m.Id == pId);
        //    _context.People.Remove(person);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}