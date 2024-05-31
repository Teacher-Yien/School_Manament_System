using System;

namespace Staff;

internal class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("Heng Long", "Male", 23),
            new("Prak Mao", "Male", 36),
            new("Keo Neary", "Female", 19),
            new Person("Mut Soryong", "Male", 56),
            new Person("Seng Dara", "Male", 34),
            new Person("Pheak Chinda", "Female", 25)
        };

        //people.ForEach(new Action<Person>(View));
        /*people.ForEach(
        delegate (Person p)
        {
            Console.WriteLine(p.GetInfo());
        }
        );*/
        //people.ForEach((Person p) => { Console.WriteLine(p.GetInfo()); });
        //people.ForEach(p => Console.WriteLine(p.GetInfo()));

        /*Action show = () => Console.WriteLine("Hello World!");
        show.Invoke();*/

        /*int totalAge = people.Sum(p => p.GetAge());
        int test = people.Total(p => p.GetAge());*/

        //exchange the reference <-> affect the whole list
        //people.Sort((x, y) => x.GetAge().CompareTo(y.GetAge()));

        //return new ordered list
        var orderNamePeople = people.OrderBy(p => p.GetName()).ToList();
    }

    /*static void View(Person p)
    {
        Console.WriteLine(p.GetInfo());
    }*/
}

public static class ListExtensions
{
    public static int Total<T>(this List<T> list, Func<T, int> func)
    {
        int result = 0;
        foreach (T item in list)
        {
            result += func(item);
        }
        return result;
    }
}

