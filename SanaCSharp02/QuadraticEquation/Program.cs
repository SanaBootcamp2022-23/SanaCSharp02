using System;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = Double.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - 4 * a * c;

            switch (D)
            {
                case > 0:
                    {
                        double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                        double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                        Console.WriteLine($"D = {D}, x1 = {x1}, x2 = {x2}");
                        break;
                    }

                case 0:
                    {
                        double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                        Console.WriteLine($"D = {D}, x1 = {x1}");
                        break;
                    }

                case < 0:
                    Console.WriteLine($"D = {D}, No solutions");
                    break;

            }
        }
    }
}
