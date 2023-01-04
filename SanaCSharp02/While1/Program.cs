int n;
double a = 0, b = 0, c = 0;
double fact = 1;
Console.Write("Enter n: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / Math.Pow(i, 2);
    fact *= i;
    c += fact;
}
Console.WriteLine($"A: {a}");
Console.WriteLine($"B: {b}");
Console.WriteLine($"C: {c}");
