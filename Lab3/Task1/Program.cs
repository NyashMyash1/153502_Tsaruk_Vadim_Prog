using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Minimum method = new Minimum();
            double z = method.Min(x, 2 * y + x) - method.Min(7 * x + 2 * y, y);
            Console.WriteLine("z: {0}", z);
        }
    }
}
