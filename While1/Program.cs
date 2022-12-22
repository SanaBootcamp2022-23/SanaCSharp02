sbyte n;
double a = 0, b = 0, c = 0, fact = 1;
Console.Write("n = ");
n = sbyte.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
    a += Math.Pow(-1, i) / (2 * n + 1);
Console.WriteLine($"a = {a}");
for (int i = 1; i <= n; i++)
    b += 1 + 1 / Math.Pow(i, 2);
Console.WriteLine($"b = {b}");
for(int i = 1; i <= n; i++)
{
    fact *= i;
    c += fact;
}
Console.Write($"c = {c}");