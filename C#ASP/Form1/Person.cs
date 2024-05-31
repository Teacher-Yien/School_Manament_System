using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public class Person
    {
        public string Name { get; set; } = default!;
        public byte Age { get; set; } = default;
        public double Height { get; set; } = default;
        public static string DataSeparator = "/";
        public static Person? Create(string data)
        {
            string[] arr = data.Split(DataSeparator);
            if (arr.Length < 3) return null;
            var name = arr[0].Trim();
            if (byte.TryParse(arr[1], out var age) == false) return null;
            if (double.TryParse(arr[2], out var height) == false) return null;
            return new Person()
            {
                Name = name,
                Age = age,
                Height = height
            };
        }
    }
    public class PersonNameComparer : IDirectionComparer<Person>
    {
        public string Text { get; set; } = "Name";
        public object? Tag { get; set; } = default;
        public IDirection Direction { get; set; } = default!;
        public int Compare(Person? x, Person? y)
        {
            return x?.Name.CompareTo(y?.Name) * Direction?.Factor ?? 0;
        }
    }
    public class PersonAgeComparer : IDirectionComparer<Person>
    {
        public string Text { get; set; } = "Age";
        public object? Tag { get; set; } = default;
        public IDirection Direction { get; set; } = default!;
        public int Compare(Person? x, Person? y)
        {
            return x?.Age.CompareTo(y?.Age) * Direction?.Factor ?? 0;
        }
    }
    public class PersonHeightComparer : IDirectionComparer<Person>
    {
        public string Text { get; set; } = "Height";
        public object? Tag { get; set; } = default;
        public IDirection Direction { get; set; } = default!;
        public int Compare(Person? x, Person? y)
        {
            return x?.Height.CompareTo(y?.Height) * Direction?.Factor ?? 0;
        }
    }
    public class PersonList : List<Person>
    {
        public void Load(string file)
        {
            if (!File.Exists(file)) return;
            Clear();
            var allLines = File.ReadAllLines(file);
            foreach (var line in allLines)
            {
                if (Person.Create(line) is Person newPerson)
                    Add(newPerson);
            }
        }
        public void Sort<TDir>(IDirectionComparer<Person> comparer)
        where TDir : IDirection, new()
        {
            comparer.Direction = new TDir();
            Sort(comparer);
        }
    }
    public class TextAction
    {
        public string Text { get; set; } = default!;
        public Action<IDirectionComparer<Person>> Action { get; set; } = default!;
    }
}
