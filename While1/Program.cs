using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double a = 0, b = 0, c = 1;
        int n;

        Console.WriteLine($"Введіть цифру");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            a += (Math.Pow(-1, n)) / (2 * n + 1);
            b += (1 + (1 / Math.Pow(n, 2)));
            c++;
        }

        Console.WriteLine($"A = {a}");
        Console.WriteLine($"B = {b}");
        Console.WriteLine($"C = {c}");
    }
}