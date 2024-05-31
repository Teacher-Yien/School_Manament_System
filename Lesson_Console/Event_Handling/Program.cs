using System.Threading.Channels;

namespace Event_Handling
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            PersonList list = new();
            Person.Create("Keo Dara", "Male", 28);
            Person.Create("Vong Neary", "Female", 58);
            Person.Create("soth yien", "Male", 18);
            Person.Create("Nita Nith", "Female", 19);
            Console.WriteLine($"Genders:{list.Genders.Aggregate((a,b)=>a+","+b)}");
            list.View();
            Console.WriteLine("\n Person in ascending of Name");
            list.People.OrderBy(p=>p.Name).ToList().ForEach(p=> Console.WriteLine(p.Info));


        }
    }
}
