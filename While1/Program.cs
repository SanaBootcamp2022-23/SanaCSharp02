Console.WriteLine("Please, enter number n");

int n = enterData();

double a = 0;

for (int i = 1; i <= n; i++)
{
    a += (Math.Pow(-1, i)/(2 * i + 1));
}

Console.WriteLine($"a = {a}");

double b = 0;

for(int i = 1; i <= n; i++)
{
    b += (1 + 1 / Math.Pow(i, 2));
}

Console.WriteLine($"b = {b}");

ulong c = 0;

for (int i = 1; i <= n; i++)
{
    c +=(ulong)Factorial(i);
}

Console.WriteLine($"c = {c}");

int enterData()
{
    string consoleString = Console.ReadLine();
    return int.Parse(consoleString);
}

int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}
