using System;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int n, i;
            double a = 0, b = 0, c = 0, factorial = 1;
            Console.WriteLine("Введіть n: ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                a += Math.Pow(-1, i) / (2 * i + 1);
                b += 1 + 1 / Math.Pow(i, 2);
                factorial *= i;
            }
            Console.WriteLine($"Результат a: {a}");
            Console.WriteLine($"Результат b: {b}");
            Console.WriteLine($"Результат c: {factorial}");
        }
    }
}



