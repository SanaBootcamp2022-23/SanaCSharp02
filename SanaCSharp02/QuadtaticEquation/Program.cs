
double a, b, c;
Console.WriteLine("Solving a quadratic equation ax^2 + bx + c = 0");
Console.WriteLine("Enter a:");
if (!ParseNumber(Console.ReadLine() ?? "", out a))
    return;
Console.WriteLine("Enter b:");
if (!ParseNumber(Console.ReadLine() ?? "", out b))
    return;
Console.WriteLine("Enter c:");
if (!ParseNumber(Console.ReadLine() ?? "", out c))
    return;

Console.WriteLine("--------------------------------");
Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");

double D = Math.Pow(b, 2) - 4 * a * c;

Console.WriteLine($"D = b^2 - 4ac = {D:F2}");

Console.WriteLine("--------------------------------");
if (D > 0)
{
    double x1, x2;

    x1 = (-b + Math.Sqrt(D)) / 2 * a;
    x2 = (-b - Math.Sqrt(D)) / 2 * a;

    Console.WriteLine($"x1 = {x1:F2}");
    Console.WriteLine($"x2 = {x2:F2}");

}
else if (D == 0) 
{
    double x = -b / 2 * a;
    Console.WriteLine($"x = {x:F2}");
}
else
{
    Console.WriteLine("The equation has no roots");
}

bool ParseNumber(string number, out double result)
{
    if (double.TryParse(number, out result))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Error, enter number!");
        return false;
    }
}
