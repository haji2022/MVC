using Microsoft.AspNetCore.Mvc;
using BasicMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMVC.Controllers
{
    public class AjaxController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public static int _id;
        public static PeopleViewModel p = new();


        [HttpGet]
        public IActionResult People()
        {
            _id = 1;
            if (p.Drivers.Count == 0)
            {
                PeopleViewModel peopleViewModel = new PeopleViewModel("Yuan", "+4098 111 071", "stockholm", _id++);
                p.Drivers
               


                _id = p.Drivers.Count();
            }
            return PartialView("AjaxPerson", p);
        }


        [HttpPost]
        public IActionResult Details(int id)
        {


            PeopleViewModel ss = new();
            ss.Drivers = p.Drivers.Where(item => item.Id == id).ToList();

            return PartialView("AjaxPerson", ss);


        }


        [HttpGet]
        public ActionResult Delete(int id)
        {

            PeopleViewModel ss = new();
            ss.Drivers = p.Drivers.Where(item => item.Id == (id)).ToList();

            p.Drivers.Remove(ss.Drivers[0]);


            return PartialView("AjaxPerson", p);
        }
    }

}