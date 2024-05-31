using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_calss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] arr= new float[10];
            int i=0;
            int menu=0;
            int n;
            do
            {

                switch (menu)
                {
                    case 1: 
                        Console.WriteLine("=============Input==============");
                        Console.WriteLine("Input Number of Array=");
                        n= int.Parse(Console.ReadLine());   
                        for(i = 0; i < n; i++)
                        {
                        Console.Write("Input Array[" + i + "]=");
                            arr[i]= float.Parse(Console.ReadLine());
                        }
                        
                        break;
                }
                Console.ReadKey();
            } while (true);
        }
    }
}
