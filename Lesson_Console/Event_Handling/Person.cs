using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{

    public class Person
    {
        public delegate void CreateHandler(Person p);
        private Person() { }
        public static event CreateHandler? Created;

        public static void Create(string n, string g, byte a)
        {
            Created?.Invoke(new Person()
            {
                Name = n,
                Gender = g,
                Age = a
            });
        }
        public string Name { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
        public string Info => $"Name:{Name},Gender:{Gender},Age:{Age}";

        
    }



    public class PersonList
    {
        private List<Person> _pers = new();
        public PersonList()
        {
            Person.Created += p => _pers.Add(p);
        }
        public List<Person> People => _pers;
        public List<string> Genders => _pers.Select(p=> p.Gender).Distinct().ToList();

        public void View()
        {
            Genders.ForEach(g =>
            {
                var filters = _pers.Where(p => p.Gender == g).ToList();
                filters.ForEach(P =>
                {
                    Console.WriteLine($"Name : {P.Name},Age:{P.Age}");
                });
            });
        }


    }

}
