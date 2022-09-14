using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Language
    {

        public Language()
        {

        }


        public Language(int id, string name)
        {
            LangId = id;
            Name = name;

        }

        public List<Person> People = new List<Person>();



        [Key]
        public int LangId { get; set; }
        public string Name { get; set; }




    }
}