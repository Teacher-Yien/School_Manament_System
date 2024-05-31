using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_with_funtion
{
    internal class Program
    {
        static void funtiona1(int id,String name,String sex,float Salary)
        {
            Console.WriteLine("\t id \t Name \t Gender\tSalary");
            Console.WriteLine("\t"+id+"\t"+name+"\t"+sex+"\t"+Salary);
        }
        static void Main(string[] args)
        {
            int id = 110;
            String name = "Yien";
            String sex = "Male";
            float Salary = 2000;
            funtiona1(id, name, sex, Salary);
            Console.ReadKey();
        }
    }
}
