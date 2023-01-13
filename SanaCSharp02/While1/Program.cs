double a = 0, b = 0, c = 0;
int n, result = 1;

do
{
    Console.Write("Input positive integer, value = ");
} while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

while(n>0)
{
    a += (Math.Pow(-1, n) / (double)(2.0 * n + 1.0));
    b += (1 + 1.0 / (Math.Pow(n, 2)));
    for (int y = 1; y <= n; y++)
    {
        result *= y;
    }
    c += result;
    result = 1;
    n--;
}
Console.WriteLine($"Value of a, {a}");

Console.WriteLine($"Value of b, {b}");

Console.WriteLine($"Value of c, {c}");