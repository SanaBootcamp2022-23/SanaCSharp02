double a = 0, b = 0;
int n, i = 1, c = 0;

Console.Write("Enter value a: ");
while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
{
    Console.Write("Invalid value, Try again: ");
}

while (i <= n)
{
    a += Math.Pow(-1.0, i) / (2.0 * i + 1);
    b += 1 + (1 / Math.Pow(i, 2));
    int fact = 1;
    for (int j = 1; j <= i; j++)
    {
        fact *= j;
    }
    c += fact;
    i++;
}
Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");