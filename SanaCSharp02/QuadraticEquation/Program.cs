using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введiть число b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введiть число c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant < 0)
                Console.WriteLine("Коренiв немає");

            else if (discriminant == 0)
                Console.WriteLine($"x = {-b / 2 * a}");

            else
            {
                Console.WriteLine($"x1 = {(-b + Math.Sqrt(discriminant)) / (2 * a)}");
                Console.WriteLine($"x2 = {(-b - Math.Sqrt(discriminant)) / (2 * a)}");
            }
        }
    }
}
