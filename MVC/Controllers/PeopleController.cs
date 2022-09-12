

using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class PeopleController : Controller
    {
        readonly ApplicationDbContext _context;

        public PeopleController(ApplicationDbContext context) //skickar in en context i en constructor
        {
            _context = context; //initiserar värdet
        }
        public static PeopleViewModel staticM = new PeopleViewModel();

        //private static int _id = staticM.Drivers.Count();
        public IActionResult Index()
        {
            staticM.Drivers = _context.People.ToList();          
            return View(staticM);
        }

        [HttpPost]

        public IActionResult Search(PeopleViewModel mo)
        {
            if (mo.SearchFilter.Length > 0)
            {
                //Filter out rows
                //PeopleViewModel m = new PeopleViewModel();
                mo.Drivers = staticM.Drivers.Where(item => (item.Name.Contains(mo.SearchFilter) )).ToList();
                return View("Index",mo);
            }

            //Just return to the list
            return View("Index", staticM);


        }


        [HttpPost]
        public IActionResult Add(PeopleViewModel m, int cityId)
        {
            //int _id = staticM.Drivers.Count();
            if (ModelState.IsValid)
            {
                Person p = new Person();
                p.Name = m.Name;
                p.CityId = cityId;
                p.Phone = m.Phone;
                //p.Id = ++_id;
                staticM.Drivers.Add(p);
               // _Context.People.Add(mm);
               // _Context.savechanges();

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

