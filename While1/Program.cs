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
            double a = 0, b = 0, c = 0, n;
            Console.Write(" Введіть n:");
            n = double.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                a += (Math.Pow(-1, i)) / (2 * i + 1);
            }
            Console.WriteLine($" а = {a}");
            for (int i = 1; i < n; i++)
            {
                b += (1 + 1 / Math.Pow(i, 2));
            }
            Console.WriteLine($" b = {b}");
            int fact = 1;
            for(int i = 1; i <= n; i++, fact *= i)
{
                c += fact;
            }
            Console.WriteLine($" c = {c}");
        }
    }
}