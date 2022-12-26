using static System.Math;
Console.WriteLine("Введiть натуральне число n");
int n;
n = int.Parse(Console.ReadLine());
double a, b, c;
double cres = 0;
a=b=c=0;
for(int i = 1; i <= n; i++)
{
    a = a + Pow(-1, i) / (2 * i + 1);
    b = b + (1 + 1 / (i * i));
}
Console.WriteLine($"Result of a = {a}");
Console.WriteLine($"Result of b = {b}");
int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}
for (int i = 1; i <= n; i++)
{
    cres = cres + Factorial(i);
}
Console.WriteLine($"Result of c = {cres}");