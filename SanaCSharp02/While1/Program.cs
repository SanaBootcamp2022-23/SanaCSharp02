int n;

do
{
    Console.Write($"Enter n: ");
    if (int.TryParse(Console.ReadLine(), out n) && n >= 1)
        break;
    else
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering n: ");
    }
} while (int.TryParse(Console.ReadLine(), out n) && !(n >= 1));


double a = 0, b = 0, c = 0;

// 1
for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * n + 1);
}

Console.WriteLine($"1) Sequence a: {Math.Round(a, 2)}");


// 2
for (int i = 1; i <= n; i++)
{
    b += (1 + 1 / (i * i));
}

Console.WriteLine($"2) Sequence b: {Math.Round(b, 2)}");


// 3
for (int i = 1; i <= n; i++)
{
    double Factorial = 1;
    for (int j = i; j >= 1; j--)
    {
        Factorial *= j;
    }
    c += Factorial;
}

Console.WriteLine($"3) Sequence c: {Math.Round(c, 2)}");