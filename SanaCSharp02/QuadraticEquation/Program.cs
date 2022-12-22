double DoubleInputValue(string text)
{
    bool check = false;
    double val = 0;
    while (!check)
    {
        Console.Write(text);
        check = double.TryParse(Console.ReadLine(), out val);
        if (!check)
        {
            Console.WriteLine("Incorect input, you must write double value.");
        }
    }
    return val;
}

double a = DoubleInputValue("a = ");
double b = DoubleInputValue("b = ");
double c = DoubleInputValue("c = ");

double D = b * b - 4 * a * c;

Console.WriteLine("\nResult of calculating:");
Console.WriteLine($"D = {D}");

if (D > 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}
else if (D < 0)
{
    Console.WriteLine($"the expression has no solutions");
}
else
{
    double x = (-b) / (2 * a);
    Console.WriteLine($"x = {x}");
}