
Console.WriteLine("Enter n");
int n = int.Parse(Console.ReadLine());
int i = 0;  double a = 0,b = 0, c = 0;
while (i <= n)
{
    a += Math.Pow(-1, n) / (2 * n + 1);
    i++;
}

i = 1;
while (i <= n)
{
    b += 1 + 1 / Math.Pow(i, 2);
    i++;
}
i = 1;
while(i <= n)
{
    int j = 0;
    while (j<=i)
    {
        c += j;
        j++;
    }
    i++;
}
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"b = {c}");