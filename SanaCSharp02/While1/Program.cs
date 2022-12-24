using Helpers;

namespace While1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("The program \"While1\"");

            Console.WriteLine("\nPlease input positive number.");
            var number = ConsoleReader.ReadUlong("n", 1);

            Console.WriteLine("\nRESULTS:");
            var resultA = CalculateA(number);
            var resultB = CalculateB(number);
            var resultC = CalculateC(number);

            Console.WriteLine($"a = {resultA}");
            Console.WriteLine($"b = {resultB}");
            Console.WriteLine($"c = {resultC}");
        }

        private static double CalculateA(ulong n)
        {
            var sum = 0.0;
            while (n >= 1)
            {
                var item = Math.Pow(-1, n) / (2 * n + 1);
                sum += item;
                n--;
            }

            return Math.Round(sum, 3);
        }

        private static double CalculateB(ulong n)
        {
            var sum = 0.0;
            while (n >= 1)
            {
                var item = 1 + (1.0 / Math.Pow(n, 2));
                sum += item;

                n--;
            }

            return Math.Round(sum, 3);
        }

        private static ulong CalculateC(ulong n)
        {
            ulong sum = 0;
            while (n >= 1)
            {
                sum += MathLibrary.Math.Factorial(n);
                n--;
            }

            return sum;
        }
    }
}