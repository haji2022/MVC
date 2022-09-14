namespace MVC.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public string Phone { get; set; }

        //public string Phone { get; set; }
        public List<Language> Languages { get; set; }

        public Person(int id, string name, int cityId, string phone)
        {
            Id = id;
            Name = name;
            CityId = cityId;
            Phone = phone;
        }


            public Person()
        {

        }


    }
}