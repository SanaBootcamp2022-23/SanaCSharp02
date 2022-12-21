using System;
using System.Data;
using System.Text;

namespace While1
{
    internal class Program
    {

        public static int factorial(int x)
        {
            int fact = 1;
            for (int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть n: ");
            int n = int.Parse(Console.ReadLine());
            
            double a = 0;
            double b = 0;
            double c = 0;

            for (int i = 1; i <= n; i++)
            {
                a += Math.Pow(-1, i) / (2 * i + 1);
                b += 1 + 1 / Math.Pow(i, 2);
                c += factorial(i);
            }

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
        }
    }
}