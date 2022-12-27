int n;
Console.WriteLine("Введіть n: ");
n = int.Parse(Console.ReadLine());
double a = 0, b = 0, c = 0;
for (int i = 1; i <= n; i++)
{
    a += (Math.Pow(-1, i) / (2 * i + 1));
    b += (1 + (1 / Math.Pow(i, 2)));
    int suma = 1;
    for (int j = 1; j <= i; j++)
    {
        suma *= j;
    }
    c += suma;
}
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("b = " + c);