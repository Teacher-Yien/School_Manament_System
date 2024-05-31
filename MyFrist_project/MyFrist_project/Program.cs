using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFrist_project
{
     class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello C#...");
            // Console.ReadLine();
            //Console.Beep();
            Console.Write("Hello Boy Yien KH=> \n You Study in Rupp Yet!\n");
            int x;
            x = 123;
            Console.WriteLine("Input X is: "+x);
            float y;
            y = 145.0f;
            Console.WriteLine("Input Y is: "+y);
            float z;
            z = x + y;
            Console.WriteLine("Show Reult is: "+z);
            double height = 600.75;
            Console.WriteLine("You Show Height is: "+height+"cm");
            char symbol = '@';
            String username = "YienKh";
            String gmail = "gmail.com";
            String show = username + symbol + gmail;
            Console.WriteLine("Show Emal is : " + show);
            Console.ReadKey();

        }
    }
}
