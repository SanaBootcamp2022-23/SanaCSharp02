uint n;
double a = 0, b = 0, c = 0;
do
{
    try
    {
        Console.WriteLine("Enter natural number  : ");
        n = uint.Parse(Console.ReadLine());
        if (n == 0) throw new InvalidOperationException();
        else break;
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Input Error");
        Console.ForegroundColor = ConsoleColor.White;
    }

} while (true);
for (int i = 1; i <= n; i++)
{
    a += (Math.Pow(-1, i) / (double)(2.0 * i + 1.0));
}
Console.WriteLine(a);

for (int i = 1; i <= n; i++)
{
    b += (1 + 1.0 / (Math.Pow(i, 2)));
}
Console.WriteLine(b);
int result1 = 1;
for (int i = 1; i <= n; i++)
{
    for (int y = 1; y <= i; y++)
    {
        result1 *= y;
    }

    c += result1;
    result1 = 1;
}
Console.WriteLine(c);