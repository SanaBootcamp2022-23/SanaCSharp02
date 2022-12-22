int IntInput(string text)
{
    bool check = false;
    int val = 0;
    while (!check || val < 1)
    {
        Console.Write(text);
        check = int.TryParse(Console.ReadLine(), out val);
        if (!check || val < 1)
        {
            Console.WriteLine("Incorect input, you must input an integer above 1.");
        }
    }
    return val;
}

double Factorial(int number)
{
    if (number <= 1)
    {
        return 1;
    }
    return number * Factorial(number - 1);
}

int n = IntInput("n = ");

double a = 0, b = 0, c = 0;

for (int i = 1; i <= n; i++)
{
    a += (Math.Pow(-1, i)) / (2 * i + 1);
    b += 1 + (1 / Math.Pow(i, 2));
    c += Factorial(i);
}

Console.WriteLine("\nResult of calculating:");
Console.WriteLine($"a = {Math.Round(a, 3)}");
Console.WriteLine($"b = {Math.Round(b, 3)}");
Console.WriteLine($"c = {Math.Round(c, 3)}");