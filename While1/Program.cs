using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.Write("Введіть число n = ");
int n = int.Parse(Console.ReadLine());

double a=0, b=0, c=0, factor=1;

for (int i = 1; i <= n; i++)
{
    a += (Math.Pow(-1, i) / (2 * i + 1.0));
    b += 1.0 + 1.0 / Math.Pow(i, 2);
    factor *= i;
    c += factor;
}
Console.WriteLine($"a = {a:F3}\nb = {b:F3}\nc = {c}");
