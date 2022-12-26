using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 / a;
                double x2 = (-b - Math.Sqrt(D)) / 2 / a;

                Console.WriteLine($"Solution x1 and x2: {x1} and {x2}");
            }
            else if (D == 0)
            {
                double x = -b / 2 / a; 

                Console.WriteLine($"Solution x: {x}");
            }
            else
                Console.WriteLine("Equation don't have real solution");

        }
    }
}
