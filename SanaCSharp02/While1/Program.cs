using System;

namespace While1
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Input N (number of repetitions) : ");
            int n = int.Parse(Console.ReadLine());
            double a = 0, b = 0;
            for (int i = 1; i <= n; i++)
            {
                a += Math.Pow(-1, i) / (2 * i + 1);
                b += 1 + 1 / Math.Pow(i, 2);
            }
            int c = Factorial(n);
            Console.WriteLine($"{a}\n {b}\n {c}");
        }
    }
}