using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    public interface IDirection
    {
        int Factor { get; }
    }
    public class Ascending : IDirection
    {
        public int Factor => 1;
    }
    public class Descending : IDirection
    {
        public int Factor => -1;
    }
    public interface IDirectionComparer<T> : IComparer<T>
    {
        string Text { get; set; }
        IDirection Direction { get; set; }
        object? Tag { get; set; }
    }

}
