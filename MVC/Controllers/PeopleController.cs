

using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class PeopleController : Controller
    {
        public static PeopleViewModel staticM = new PeopleViewModel();

      
        public IActionResult Index()
        {
            staticM.CreatePeopleList();
            return View(staticM);
        }

        [HttpPost]

        public IActionResult Search(PeopleViewModel mo)
        {
            if (mo.SearchFilter.Length > 0)
            {
               
                mo.Drivers = staticM.Drivers.Where(item => (item.Name.Contains(mo.SearchFilter) || item.City.Name.Contains(mo.SearchFilter))).ToList();
                return View("Index",mo);
            }

         
            return View("Index", staticM);


        }


        [HttpPost]

        public IActionResult Add(PeopleViewModel m)
        {
            int _id = staticM.Drivers.Count();
            if (ModelState.IsValid)
            {
                Person p = new Person();
                p.Name = m.Name;
                p.Phone = m.Phone;
                p.CityId = m.City.Id;
                p.Id = ++_id;
                staticM.Drivers.Add(p);
                

            }
            return View("Index", staticM);


        }



            [HttpGet]
            public IActionResult Delete(int id)
            {
                PeopleViewModel m = new();
                m.Drivers = m.Drivers.Where(item => item.Id == (id)).ToList();
                if (m.Drivers.Count != 0)
                {
                    m.Drivers.Remove(m.Drivers[0]);
                }

                return View("Person", staticM);
            }
        }

    }

