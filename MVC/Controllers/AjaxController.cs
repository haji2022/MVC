using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;


namespace MVC.Controllers
{
    public class AjaxController : Controller
    {
        public AjaxController()
        {
           m = new();
           m.CreatePeopleList();
        }

        public IActionResult Index()
        {
            return View();
        }

    
        public static PeopleViewModel m;


        [HttpGet]
        public IActionResult People()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel();
            
            return PartialView("_AjaxPerson", m);
        }


        [HttpPost]
        public IActionResult Details(int id)
        {


            PeopleViewModel ss = new();
            ss.Drivers = m.Drivers.Where(item => item.Id == id).ToList();

            return PartialView("_AjaxPerson", ss);


        }


        [HttpPost]
        public ActionResult Delete(int id)
        {

            PeopleViewModel ss = new();
            ss.Drivers = m.Drivers.Where(item => item.Id == (id)).ToList();

            m.Drivers.Remove(ss.Drivers[0]);


            return PartialView("_AjaxPerson", m);

        }
    }

}