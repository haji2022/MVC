namespace BasicMVC.Models
{
    public class Person
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }


        public string Phone { get; set; }


        public Person(int id, string name, string city, string phone)
        {
            Id = id;
            Name = name;
            City = city;
            Phone = phone;
        }


            public Person()
        {

        }


    }
}