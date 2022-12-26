using System;

namespace While1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть n:");
            double n = double.Parse(Console.ReadLine());
            RezA(n);
            RezB(n);
            RezC(n);
        }
            static void RezA(double n)
            {
                double result = 0;

                while (n > 0)
                {
                    result += Math.Pow(-1, n) / (2 * n + 1);

                    n--;
                }
                Console.WriteLine("a = {0}", result);
            }
        static void RezB(double n)
        {
            double result = 0;
            while (n > 0)
            {
                result += 1 + (1 / (n * n));
                n--;
            }
            Console.WriteLine("b = {0}", result);
        }
        static void RezC(double n)
        {
            double result = 1;
            while (n > 0)
            {

                result *= n; 
                n--;
            }
            Console.WriteLine("c = {0}", result);
        }
    }
}
