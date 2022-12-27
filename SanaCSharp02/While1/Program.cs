// See https://aka.ms/new-console-template for more information

Console.Write("Input number n = ");short n = short.Parse(Console.ReadLine());
double a = 0, b = 0, c = 1;
if (n>0)
{
    while (n > 0)
    {
        a += Math.Pow(-1, n) / (2 * n + 1);
        b += 1 + (1 / (n * n));
        c *= n;

        n--;
    }

    Console.WriteLine($"Result a = {a}");
    Console.WriteLine($"Result b = {b}");
    Console.WriteLine($"Result c = {c}");
}
else
{
    Console.WriteLine("Error");
}
