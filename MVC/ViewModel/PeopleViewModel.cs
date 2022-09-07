using System.ComponentModel.DataAnnotations;
using BasicMVC.Models;
namespace BasicMVC.ViewModel
{
    public class PeopleViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }

        [Required]
        public string Phone { get; set; }



        public PeopleViewModel(string v1, string v2, string v3, int v4)
        {
            Name = v1;
            City = v2;
            Phone = v3;
            Id = v4;

        }

        public PeopleViewModel()
        {
        }

        public List<Person> Drivers = new List<Person>();
    }
}