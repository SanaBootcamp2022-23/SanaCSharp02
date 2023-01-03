double a, b, c, n;
n = double.Parse(Console.ReadLine());
a = 0;
b = 0;
c = 0;
for (int i = 1; i <= n; i++)
{
    a += (Math.Pow(-1, n)) / (2 * n + 1);
    b += (1 + 1 / Math.Pow(n, 2));
    c += n;
}
Console.WriteLine("a = {0}", a);
Console.WriteLine("b = {0}", b);
Console.WriteLine("c = {0}", c);