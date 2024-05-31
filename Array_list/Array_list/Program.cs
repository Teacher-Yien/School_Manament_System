using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arrary list = new Arrary();
            list.Add("1001");
            list.Add("Yien");
            list.Add("12345678");
            foreach(object item  in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
