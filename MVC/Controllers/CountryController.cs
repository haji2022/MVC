using Microsoft.AspNetCore.Mvc;
using MVC.ViewModels;
using MVC.Data;
using MVC.Models;


namespace MVC.Controllers
{
    public class CountryController : Controller
    {
        readonly ApplicationDbContext _context;
        public CountryController(ApplicationDbContext context) //skickar in en context i en constructor
        {
            _context = context; //initiserar värdet
        }


        public IActionResult Index()
        {
            List<Country> countries = _context.Countries.ToList();

            return View(countries);
        }
    }
}
