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
            int n = 5;

            Console.WriteLine($"a = {Math.Round(Enumerable.Range(1, n).Sum(i => (Math.Pow(-1, i) / (2 * i + 1))), 3)}\n" +
                              $"b = {Math.Round(Enumerable.Range(1, n).Sum(i => (1 + (1.0 / (i * i)))), 3)}\n" +
                              $"c = {Enumerable.Range(1, n).Sum(i => Factorial(i))}");
        }
    }
}
