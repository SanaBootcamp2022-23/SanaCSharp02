using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int n;
double a = 0, b = 0, c = 0, factorial;

Console.Write("Введіть число n: ");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / ((2 * i) + 1.0);
    b += 1.0 + 1.0 / Math.Pow(i, 2);
    factorial = 1;
    for (int j = 1; j <= i; j++)
    {
        factorial *= j;
    }
    c += factorial;
}

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);