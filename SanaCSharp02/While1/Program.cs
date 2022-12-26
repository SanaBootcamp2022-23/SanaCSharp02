using System;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число n: ");
            int n = int.Parse(Console.ReadLine());

            double a = 0, b = 0, c = 0;

            for (int i = 1; i <= n; i++)
            {
                a += Math.Pow(-1, i) / (2 * i + 1);
                b += 1 + 1 / Math.Pow(i, 2);
                c += GetFactorial(i);
            }

            Console.WriteLine($"\na = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");

        }

        static int GetFactorial(int number)
        {
            int factorial = 1;

            for (int i = 2; i <= number; i++)
                factorial *= i;

            return factorial;
        }
    }
}
