using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;

            do
            {
                Console.WriteLine("Enter a:");
                a = int.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("a == 0");
                }
            } while (a == 0);
            Console.WriteLine("Enter b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = int.Parse(Console.ReadLine());

            d = b * b - 4 * a * c;
            Console.WriteLine($"d = {d}\n");

            double x1, x2;
            if (d == 0)
            {
                Console.WriteLine("Output\n");
                x1 = -b / (2 * a);
                Console.WriteLine($"x = {x1}");
            }
            else if (d > 0)
            {
                Console.WriteLine("Output\n");
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                Console.WriteLine("D < 0.\n");
            }

        }
    }
}
