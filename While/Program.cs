Console.Write("Enter n: ");

int n = Convert.ToInt32(Console.ReadLine());
double a = 0, b = 0, c = 1;
int i = 1, j = 1, g = 2;

while (i <= n)
{
    a += Math.Pow(-1, n) / (2 * n + 1);
    i++;
}
Console.WriteLine($"Result 1: {a}");

while (j <= n)
{
    b += 1 + (1 / Math.Pow(n, 2));
    j++;
}
Console.WriteLine($"Result 2: {b}");

while (g <= n)
{
    c *= g;
    g++;
}
Console.WriteLine($"Result 3: {c}");
