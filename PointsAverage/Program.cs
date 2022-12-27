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
            Console.WriteLine(" Допуск чи недопуск\n");
            double a, res = 0; int k = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($" Введіть оцінку {i + 1}:");
                a = double.Parse(Console.ReadLine());
                if (a > 5 || a <= 0)
                {
                    Console.WriteLine("\n Оцінка не може бути такою!");
                    goto exit;
                }
                res += a; k++;
            }
            res = res / k;
            Console.WriteLine($"\n Середній бал: {res}");
            if (res >= 4)
                Console.WriteLine(" Допуск");
            else
                Console.WriteLine(" Недопуск");
            exit: Console.ReadLine();
        }
    }
}