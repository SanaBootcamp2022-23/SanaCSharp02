using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace SanaCSharp02
{
    class Program
    {
        private static double а;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.WriteLine(" Обчислення квадратного рівняння");
            double a, b, c, x1, x2, x;
            Console.Write(" Введіть значення а:");
            a = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення b:");
            b = double.Parse(Console.ReadLine());
            Console.Write(" Введіть значення c:");
            c = double.Parse(Console.ReadLine());

            double duskriminant = b * b - 4 * a * c;
            if (duskriminant > 0)
            {
                x1 = (-b - Sqrt(duskriminant))/(2 * a);
                x2 = (-b + Sqrt(duskriminant)) / (2 * a);
                Console.WriteLine($"Корені даного рівняння: x1 = {x1}, x2 = {x2}");
            }
            else if (duskriminant == 0)
            {
                x = (-b) / (2 * a);
                Console.WriteLine($"Корень даного рівняння: x = {x}");
            }
            else
                Console.WriteLine("\nКоренів немає");
        }
    }
}