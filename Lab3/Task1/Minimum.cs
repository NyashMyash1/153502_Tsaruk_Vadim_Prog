using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Minimum
    {
        public double Min(double x, double y)
        {
            if (x.CompareTo(y) < 0)
                return x;
            else if (x.CompareTo(y) == 0)
                return x;
            else
                return y;
        }
    }
}
