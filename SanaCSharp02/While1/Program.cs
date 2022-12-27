using System.Text;

namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int n, i = 1;
            ulong c = 0;
            double a = 0, b = 0;
            bool isOk;
            do
            {
                Console.Write($"Введіть натуральне число: ");
                isOk = int.TryParse(Console.ReadLine(), out n);
                if (!isOk || n <= 0)
                    Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
            } while (!isOk || n <= 0);
            while (i <= n)
            {
                a += Math.Pow(-1.0, i) / (2.0 * i + 1);
                b += 1 + (1.0 / (i * i));
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                    factorial *= j;
                c += (ulong)factorial;
                i++;
            }
            Console.WriteLine($"Результат числа 'a' = {a}");
            Console.WriteLine($"Результат числа 'b' = {b}");
            Console.WriteLine($"Результат числа 'c' = {c}");

        }
    }
}