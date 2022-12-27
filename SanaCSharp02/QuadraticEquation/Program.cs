using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть значення a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть значення c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D > 0)
            {
                double sD = Math.Sqrt(D);
                Console.WriteLine($"Корень D: {sD}");
                double x1 = (-b + sD) / (2 * a);
                double x2 = (-b - sD) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else if (D == 0)
            {
                double sD = Math.Sqrt(D);
                Console.WriteLine($"Корень D: {sD}");
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else if (D < 0)
            {
                Console.WriteLine("Коренів немає");
            }
        }
    }
}
