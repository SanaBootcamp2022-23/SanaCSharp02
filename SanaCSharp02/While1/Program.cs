using System;

double a = 0, b = 0, c = 0, n, fact = 0;
int i = 1;

Console.Write("Enter n:");
n = Convert.ToDouble(Console.ReadLine());


while (i <= n)
{
    a = a + (Math.Pow(-1, n)) / (2 * n + 1);
    i++;
}
Console.WriteLine($"a = {a}");

i = 1;
while (i <= n)
{
    b += 1 + 1 / Math.Pow(i, 2);
    i++;
}
Console.WriteLine($"b = {b}");

i = 1;
while (i <= n)
{
    while (fact <= i)
    {
        c += fact;
        fact++;
    }
    i++;
}
Console.WriteLine($"c = {c}");