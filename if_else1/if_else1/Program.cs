using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            String name;
            float salary;


            Console.Write("Input ID:");
            id = int.Parse(Console.ReadLine());
            Console.Write("Input Name:");
            name = Console.ReadLine();
            Console.Write("Input Salary:");
            salary = float.Parse(Console.ReadLine());
            if(salary <= 100.0f)
            {
                salary = salary*0.15f;
            }
            else
            {
                Console.WriteLine("SALARY IS:" + salary);
            }
            Console.WriteLine("ID:" + id);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Salary:" + salary);
            Console.ReadKey();

        }
    }
}
