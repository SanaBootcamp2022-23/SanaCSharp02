using System.Runtime.CompilerServices;
using System.Numerics;
namespace While1
{
    internal class Program
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static int Factorial(int n)
        {
            return Enumerable.Range(1, n).Aggregate(1, (f, i) => f * i);
        }

        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                a += (Math.Pow(-1, i) / (2 * i + 1));
                b += (1 + (1.0 / (i * i)));
                c += Factorial(i);
            }

            Console.WriteLine($"a = {Math.Round(a, 3)}\nb = {Math.Round(b, 3)}\nc = {Math.Round(c, 3)}");
        }
    }
}