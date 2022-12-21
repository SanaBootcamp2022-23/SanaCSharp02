Console.Write("n = ");
int factor = 1, n = int.Parse(Console.ReadLine());
double a = 0, b = 0, c = 0;
for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / Math.Pow(i, 2);
    factor *= i;
    c += factor;
}
Console.WriteLine($"a={a}\n" +
    $"b={b}\n" +
    $"c={c}");