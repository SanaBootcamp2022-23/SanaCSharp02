using System.Text;
Console.OutputEncoding = Encoding.UTF8;
double fact(int N)
{
    if (N < 0)
        return 0;
    if (N == 0)
        return 1;
    else
        return N * fact(N - 1);
}
int n;
double a=0, b=0, c=0;

Console.Write("Введіть число n:");
n = Convert.ToInt16(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    double res;
    res = (Math.Pow(-1, i)) / (2 * i + 1);
    a += res;
}

for (int i = 1; i <= n; i++)
{
    double res;
    res = (1 + (1 / (Math.Pow(i, 2))));
    b += res;
}

for (int i = 1; i <= n; i++)
{
    double res;
    res = fact(i);
    c += res;
}
Console.WriteLine("a:" + a);
Console.WriteLine("b:" + b);
Console.WriteLine("c:" + c);