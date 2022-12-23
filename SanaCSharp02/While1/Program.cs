

Console.WriteLine("Enter n(int): ");
try
{
    int n = int.Parse(Console.ReadLine());
    double a = 0, b = 0, c = 0;
    while (n > 0)
    {
        a += Math.Pow(-1, n) / (2 * n + 1);
        b += 1 + 1 / Math.Pow(n, 2);
        c += Factorial(n);
        n--;
    }
    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    Console.WriteLine($"c = {c}");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}

double Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}