using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Services;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Solution Method = new Solution();
            Method.Sol(z);
        }
    }
}
