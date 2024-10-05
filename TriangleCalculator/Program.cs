using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Въведете страната A: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Въведете страната B: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Въведете страната C: ");
                double c = double.Parse(Console.ReadLine());

                double obikolka = a + b + c;
                double s = obikolka / 2;
                double lice = Math.Sqrt(s * (s - a) * (s - b) * (s - b) * (s - c));

                Console.WriteLine($"Обиколката е равна на {obikolka}");
                Console.WriteLine($"Лицето е равно на {lice}");

                if (a == b && b == c)
                {
                    Console.WriteLine("Триъгълника е равностранен.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Триъгълника е равнобедрен.");
                }
                else if (a + a + b + b == c * c || a + a + c + c == b * b || b + b + c + c == a * a)
                {
                    Console.WriteLine("Триъгълникът е правоъгълен.");
                }
            }
        }
    }
}
