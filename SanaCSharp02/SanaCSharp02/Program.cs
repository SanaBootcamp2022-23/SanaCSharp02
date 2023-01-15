using System;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            double D, x, x1, x2, a, b, c; ;
            Console.Write("Введіть a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введіть b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введіть c: ");
            c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Помилка!");
                return;
            }
            else
            {
                Console.Write($"Квадратне рівняння: {a}x^2 + {b}x + {c} = 0.\n");
                D =Math.Pow(b, 2) - 4 * a * c;
                Console.Write($"Дискримінант = {D}\n");
                if (D == 0)
                {
                    x = -b / (2 * a);
                    Console.Write($"Рівняння має один корінь X = {x}");
                }
                else if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.Write($"Рівняння має два корені: \nX1={x1}\nX2={x2}");
                }
                else
                {
                    Console.Write("Дискримінант менше 0. Рівняння не має жодного кореня!");
                }
            }
        }
    }
}
