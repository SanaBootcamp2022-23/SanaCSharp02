using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
namespace QuadraticEquation
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double a, b, c;

            a = GetNumber("a");
            b = GetNumber("b");
            c = GetNumber("c");

            SolveQuadraticEquation(a, b, c);

            Console.ReadKey();
        }
        static double GetNumber(string name)
        {
            double number;
            do
            {
                Console.WriteLine($"Введіть число {name}:");
                if (!double.TryParse(Console.ReadLine(), out number))
                    Console.WriteLine($"Помилка у введені числа! Спробуйте ще раз. \nВведіть числo {name}:");
                else
                {
                    Console.WriteLine($"Число {number} записано!\n");
                    break;
                }

            } while (true);
            return number;
        }

        static void SolveQuadraticEquation(double a, double b, double c)
        {
            double d, x1, x2;

            d = b * b - 4 * a * c;

            if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"x1 = {x1}\n");
                Console.WriteLine($"x2 = {x2}\n");
            }
            else if (d == 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"x1 = {x1} \n");
            }
            else
            {
                Console.WriteLine("Рівняння не має розв'язків!\n");
            }
        }
    }
}
