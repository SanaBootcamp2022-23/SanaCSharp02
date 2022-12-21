using System;
using System.Text;
namespace QuandraticEquation
{

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Квадратне рівняння");

            Console.Write("Введіть a:");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Введіть b:");
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Введіть c:");
            double c = double.Parse(Console.ReadLine());
            

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if(discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2*a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корені рівняння: {x1} і {x2}");
            }
            else if (discriminant == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine($"Корінь рівняння, дискримінант дорівнює 0): {x1}");
            }
            else
            {
                Console.WriteLine("Немає коренів, дискримінант меньше нуля");
            }
        }

    }
}