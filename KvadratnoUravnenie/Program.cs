using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratnoUravnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            while (true)
            {
                Console.Write("Въведете (a): ");
                a = double.Parse(Console.ReadLine());

                Console.Write("Въведете (b): ");
                b = double.Parse(Console.ReadLine());

                Console.Write("Въведете (c): ");
                c = double.Parse(Console.ReadLine());

                double d = b * b - 4 * a * c;
                Console.WriteLine($"Дискриминантата е {d}");

                if (d < 0)
                {
                    Console.WriteLine("Няма реални корени!");
                }
                else if (d == 0)
                {
                    double xEqual = -b / (2 * a);
                    Console.WriteLine($"Двата корена са равни: X = {xEqual}");
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"X1 = {x1}, X2 = {x2}");
                }

                Console.Write("Искате ли да изчислите ново уравнение? (Да/Не): ");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "да")
                {
                    break;
                }
            }
        }
    }
}