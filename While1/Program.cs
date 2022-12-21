uint n, factorial;
double a = 0, b = 0, c = 0;

Console.Write("Введіть натуральне число n: ");
n = uint.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / Math.Pow(i, 2);
    factorial = 1;
    for (uint j = 1; j <= i; j++)
        factorial *= j;
    c += factorial;
}

Console.WriteLine($"\na = {a}\nb = {b}\nc = {c}");