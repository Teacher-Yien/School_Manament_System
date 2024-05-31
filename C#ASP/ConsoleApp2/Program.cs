using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        public delegate double Calculation(double x, double y);
        static double Add(double x, double y) => x + y;
        static double Sub(double x, double y) => x - y;
        static double Mul(double x, double y) => x * y;
        static double Div(double x, double y) => x / y;

        static void Main(string[] args)
        {
            List<Calculation> cal = new List<Calculation> { Add, Sub, Mul, Div };
            Console.WriteLine("Basic Calculation");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Sub");
            Console.WriteLine("3. Mul");
            Console.WriteLine("4. Div");
            Console.Write("Please input number(1, 2, 3, 4) to select the calculation : ");
            string? input = Console.ReadLine();
            if (input == null) { return; }
            int index = int.Parse(input) - 1; // Subtract 1 to match the index in the list

            if (index >= 0 && index < cal.Count)
            {
                double result = cal[index].Invoke(30, 4);
                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
