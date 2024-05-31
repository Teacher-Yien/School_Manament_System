using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.Write("Input Number1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input Number2:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input operator:");
            char Operator = char.Parse(Console.ReadLine());
            switch(Operator)
            {
                case '+':
                    {
                        Console.WriteLine("Num1+Num2="+(num1+num2));
                }break;
                case '-':
                    {
                        Console.WriteLine("Num1+Num2=" + (num1 - num2));
                 }break;
                case '*':
                    {
                        Console.WriteLine("Num1+Num2=" + (num1 * num2));
                }break;
                case '/':
                    {
                        Console.WriteLine("Num1+Num2=" + (num1 / num2));
                 }break;
                case '%':
                    {
                        Console.WriteLine("Num1+Num2=" + (num1 % num2));
                }break;
            }
            Console.ReadKey();

        }
    }
}
