namespace MVC.Models
{
    public class Country
    {
        public Country()
        {

        }


        public Country(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<City> Cities = new List<City>();
    }

}