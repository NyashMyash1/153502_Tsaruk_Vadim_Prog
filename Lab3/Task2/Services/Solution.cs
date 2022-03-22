using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    public class Solution
    {
        public void Sol(int z)
        {
            double x = 0;
            Console.Write("Ветка: ");
            if (z < -1)
            {
                x = (double)-z / 3;
                Console.WriteLine("z < -1");
            }
            else if (z >= -1)
            {
                Console.WriteLine("z >= -1");
                x = Math.Abs(z);
            }
            double y = Math.Log(x + 0.5) + (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x));
            Console.WriteLine("Результат: {0}", y);
        }
        public double Sol_Test(int z)
        {
            double x = 0;
            if (z < -1)
            {
                x = (double)-z / 3;
            }
            else if (z >= -1)
            {
                x = Math.Abs(z);
            }
            double y = Math.Log(x + 0.5) + (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x));
            return y;
        }
    }
}
