using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rec
{
    public class Rectangle
    {
        public int No { get; init; }
        public double width { get; set; }


        public double lenght { get; set; }
        public double Area => width * lenght;

    }
}
