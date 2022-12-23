double a = 0, b = 0, c = 0;
Console.WriteLine("enter n:");
int n = int.Parse(Console.ReadLine());

while (n>0)
{
    a += Math.Pow(-1, n) / (2 * n + 1);
    b += 1 + 1 / Math.Pow(n, 2);
    c += factorial(n);
    n--;
}
Console.WriteLine($"a:{a}\nb:{b}\nc:{c}");

double factorial(int n)
{
    if (n == 1)
        return 1;
    else
        return n * factorial(n - 1);
}
