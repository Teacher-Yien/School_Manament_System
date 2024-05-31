using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public static string Separator { get; set; } = "/";
        private static int count = 0;
        public static Person? CreateInstance(string data)
        {
            string[] arr = data.Split(Separator);
            if (arr.Length < 3) return null;
            if (byte.TryParse(arr[2], out byte age) == false) return null;
            Person newPer = new Person()
            {
                Name = arr[0].Trim(),
                Gender = arr[1].Trim(),
                Age = age,
            };
            return newPer;
        }
        public int No { get; init; } = 0;
        public virtual string Name { get; set; } = default!;
        public virtual string Gender { get; set; } = default!;
        public virtual byte Age { get; set; } = default;
        public virtual string Info => $"name:{Name}, gender:{Gender}, age:{Age}";
        public Person(string name = "", string gender = "", byte age = 0)
        {
            No = ++count;
            Name = name;
            Gender = gender;
            Age = age;
        }
    }
}
