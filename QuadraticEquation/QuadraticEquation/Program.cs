using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c:");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"D={d}");
            if (d < 0)
            {
                Console.WriteLine("Розв'язків не має");
            }
            else if (d == 0)
            {
                Console.WriteLine(x1);
            }
            else if (d > 0)
            {
                Console.WriteLine($"x1={x1}");
                Console.WriteLine($"x2={x2}");
            }
        }
    }
}
