using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a, b, c:");
            double a = Convert.ToDouble(Console.ReadLine()), b = Convert.ToDouble(Console.ReadLine()), c = Convert.ToDouble(Console.ReadLine());
            double D = b * b - 4 * a * c;
            Console.WriteLine($"D={D}");
            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                double x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1={x1}\nx2={x2}");
            }
            else if (D == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine($"x={x}");
            }
            else Console.WriteLine("Roots don`t exist.");
        }
    }
}