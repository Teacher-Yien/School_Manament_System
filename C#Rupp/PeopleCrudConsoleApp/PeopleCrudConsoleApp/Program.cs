


using Microsoft.Owin.BuilderProperties;
using System.Net.Sockets;

internal class Program
{
    public static List<Person> people = new()
    {
        new Person{No=1001,Name="Bopha",Gender="Male",Age=23,Address="PhomPhenh" },
        new Person{No=1002,Name="yien",Gender="Male",Age=21,Address="PhomPhenh" },
        new Person{No=1003,Name="kh",Gender="Female",Age=19,Address="PhomPhenh" },
        new Person{No=1004,Name="java",Gender="Female",Age=25,Address="PhomPhenh" },
    };


    private static void Main(string[] args)
    {
        MenuBank menuBank = new MenuBank()
        {
            Title = "People",
            Menues = new()
    {
        new Menu() { Text = "Viewing", Action=View},
        new Menu() { Text = "Creating", Action=Create},
        new Menu() { Text = "Sorting", Action=Sort },
        new Menu() { Text = "Searching", Action=Search},
        new Menu() { Text = "Deleting", Action=Delete},
        new Menu() { Text = "Exiting", Action=Exit}
    }
        };

        while (true)
        {
            Console.WriteLine();
            menuBank.Show();
            var actinveMenu = menuBank.GetMenu(new string(' ', 2));
            Console.WriteLine();
            actinveMenu.Action();
        }

        static void View()
        {
            Console.WriteLine(">>Viewing");
            Console.WriteLine("Implement your code to perform this task");
            Console.WriteLine($"{ "No",+10}{"Name",+10}{"Gender",+10}{"Age",+10}{"Address",+15}");
            Console.WriteLine(new string('=',+10+10+10+10+15));
            people.ForEach(e =>
            {
            Console.WriteLine($"{e.No,+10}{e.Name,+10}{e.Gender,+10}{e.Age,+10}{e.Address,+15}"); 
            
            });
            }
        static void Create()
        {
            Person person = new Person();
            Console.WriteLine(">>Creating");
            Console.WriteLine("Implement your code to perform this task");
            Console.WriteLine("Create No:  ");person.No = long.Parse(Console.ReadLine());
            Console.WriteLine("Create Name:  "); person.Name = Console.ReadLine();
            Console.WriteLine("Create Gender:  "); person.Gender = Console.ReadLine();
            Console.WriteLine("Create Age:  "); person.Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Create Address:  "); person.Address = Console.ReadLine();
            people.Add(person);
        }
        static void Sort()
        {
            Console.WriteLine(">>Sorting");
            Console.WriteLine("Implement your code to perform this task");
            // ascending
            // people.Sort((p1, p2) => string.Compare(p1.Name, p2.Name, StringComparison.Ordinal));
            // descending
            // people.Sort((p1, p2) => string.Compare(p2.Name, p1.Name, StringComparison.Ordinal));
            Console.WriteLine(">>Sorting by Age");
            people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));
            people.ForEach(e =>
            {
                Console.WriteLine($"{e.No,+10}{e.Name,+10}{e.Gender,+10}{e.Age,+10}{e.Address,+15}");

            });
        }
        static void Search()
        {

            Console.WriteLine(">>Searching");
            Console.WriteLine("Implement your code to perform this task");
            string? searchName=default;
            Console.Write("Search Name is: ");searchName = Console.ReadLine();
            Console.WriteLine($">>Searching for '{searchName}' by Name");

            var results = people.Where(p => p.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase)).ToList();

            if (results.Count <= 0)
            {
                Console.WriteLine("No matching records found.");
            }
            else
            {
                Console.WriteLine($"{"No",+10}{"Name",+10}{"Gender",+10}{"Age",+10}{"Address",+15}");
                Console.WriteLine(new string('=', +10 + 10 + 10 + 10 + 15));

                results.ForEach(e =>
                {
                    Console.WriteLine($"{e.No,+10}{e.Name,+10}{e.Gender,+10}{e.Age,+10}{e.Address,+15}");
                });
            }
        }
        static void Delete()
        {
            Console.WriteLine(">>Deleting");
            Console.WriteLine("Implement your code to perform this task");
            string? deleteName = default;
            Console.WriteLine("Delete By name: ");deleteName= Console.ReadLine();
            Console.WriteLine($">>Deleting '{deleteName}' by Name");

            var personToDelete = people.FirstOrDefault(p => p.Name.Equals(deleteName, StringComparison.OrdinalIgnoreCase));

            if (personToDelete != null)
            {
                people.Remove(personToDelete);
                Console.WriteLine($"Person '{deleteName}' has been deleted.");
            }
            else
            {
                Console.WriteLine($"Person '{deleteName}' not found. No deletion performed.");
            }

        }
        static void Exit()
        {
            Console.WriteLine(">>Exiting");
            Environment.Exit(0);
        }
    }
}