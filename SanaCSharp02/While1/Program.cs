using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a = 0, b = 0, c = 1, n, factorial = 1;
Console.Write("Введіть число: ");   n = double.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    a += Math.Pow((-1), i) / (2 * i + 1);
}
for (int i = 1; i <= n; i++)
{
    b += 1 + (1 / Math.Pow(i, 2));
}
for (int i = 1; i <= n; i++)
{
    c *= i;
}
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");