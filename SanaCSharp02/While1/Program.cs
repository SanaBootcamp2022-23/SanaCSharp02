using System;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double a = 0, b = 0, c = 0;

            int i = 1;

            int temp = 1;
            while(i <= n)
            {
                a += Math.Pow(-1, n) / (2 * i + 1);

                b += (1 + 1 / Math.Pow(i, 2));
                
                temp *= i;
                c += temp;
            }

            Console.WriteLine($"A = {a}, B = {b} and C = {c}");
        }
    }
}
