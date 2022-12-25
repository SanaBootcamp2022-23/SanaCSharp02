class Program
{
    static void Main()
    {
        double n, factorial, a = 0, b = 0, c = 0;
        Console.WriteLine("Enter a number");
        n = double.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            a += Math.Pow(-1, i) / (2 * i + 1);
        }
        for (int i = 1; i <= n; i++)
        {
            b += 1 + (1 / Math.Pow(i, 2));
        }
        for (int i = 1; i <= n; i++)
        {
            factorial = 1;
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            c += factorial;
        }
        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"c = {c}");
    }
}