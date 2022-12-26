using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a = 0, b = 0, c = 0, fact = 1;
            int n;
            Console.WriteLine("Введіть значення n");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                c += fact;
            }
            while (n > 0) {
                a += Math.Round(-1.0, n) / ((2 * n) + 1);
                b += 1 + (1 / Math.Pow(n, 2));
                n--;
            }
            Console.WriteLine("\na = {0}, b = {1}, c = {2}", a, b, c);
        }
    }
}