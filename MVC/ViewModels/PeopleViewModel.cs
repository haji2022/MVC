using MVC.Models;
using System.ComponentModel.DataAnnotations;
namespace MVC.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }

        [Required]
        public string Phone { get; set; }

        public string SearchFilter { get; set; } = "";

        public List<Person> Drivers { get; set; } = new List<Person>();

        public void CreatePeopleList()
        {
            Person p = new Person(1, "Kalle", "131452658", "Angered");
            Drivers.Add(p);
            p = new Person(2, "Anders", "13154876", "Kållered");
            Drivers.Add(p);
            p = new Person(3, "Ahmed", "1234568", "Frolunda");
            Drivers.Add(p);
        }
    }
        

    }
