using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Task1
    {
        public bool divide(int m, int n)
        {
            if (m % n == 0)
                return true;
            else 
                return false;
        }
        static void Main(string[] args)
        {
            bool IsTrue = true;

            while (IsTrue)
            {
                Console.Write("Введите M: ");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Task1 method = new Task1();
                if (method.divide(m, n))
                {
                    Console.WriteLine($"Частное: {m / n}");
                }
                else
                {
                    Console.WriteLine("M на N нацело не делится");
                }

                string s = null;
                while (s != "1" && s != "2")
                {
                    Console.WriteLine("Выберите пункт:");
                    Console.WriteLine("1) Продолжить;");
                    Console.WriteLine("2) Закончить;");
                    s = Console.ReadLine();
                }
                switch (s)
                {
                    case "1":
                        continue;
                    case "2":
                        IsTrue = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
