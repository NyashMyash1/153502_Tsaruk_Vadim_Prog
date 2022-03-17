using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Task2
    {
        public int solution(double x, double y)
        {
            if (x < 15 && y < 15)
            {
                if (Math.Abs(x) == y || Math.Pow(x, 2) + Math.Pow(y, 2) == 225)
                {
                    return 1;
                }
                else if (Math.Abs(x) < y)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            bool IsTrue = true;

            while (IsTrue)
            {
                Console.Write("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y: ");
                double y = Convert.ToDouble(Console.ReadLine());
                Task2 method = new Task2();
                if(method.solution(x ,y) == 1)
                {
                    Console.WriteLine("На границе");
                }
                else if(method.solution(x, y) == 2)
                {
                    Console.WriteLine("Да");
                }
                else
                {
                    Console.WriteLine("Нет");
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
