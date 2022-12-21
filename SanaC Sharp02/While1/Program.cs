int n;
double a = 0;
double b = 0;
double c = 0;
int fact = 1;
Console.Write("Enter n = ");
n = int.Parse(Console.ReadLine());
for (int i  = 1; i <= n; i++)
{
    a += Math.Pow(-1, n) / (2.0 * n + 1);
    b += (1 + (1.0 / (n * n)));
    fact *= i;
    c += fact;
}
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");
