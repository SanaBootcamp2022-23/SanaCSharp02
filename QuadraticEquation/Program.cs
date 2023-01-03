
double a, b, c;
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
double D, x1, x2, x;
if (a == 0)
{
    if (b != 0)
    {
        x = -c / b;
        Console.WriteLine($"x = {x}");
    }
    else
    {
        Console.WriteLine("Рішень немає");
    }
}
if (b == 0)
{
    if (a != 0)
    {
        x = Math.Sqrt(-c / a);
        Console.WriteLine($"x = {x}");
    }
    else
    {
        Console.WriteLine("Рішень немає");
    }
}
if (c == 0)
{
    if (a == 0)
    {
        Console.WriteLine("x = 0");
    }
    else if (b == 0)
    {
        Console.WriteLine("x = 0");
    }
    else if (a != 0 && b != 0)
    {
        x1 = 0;
        x2 = -b;
        Console.WriteLine($"x1 = {x1}");
        Console.WriteLine($"x2 = {x2}");
    }
}
if (a != 0 && b != 0 && c != 0)
{
    D = Math.Pow(b, 2) - 4 * a * c;
    x1 = (-b + Math.Sqrt(D)) / (a * 2);
    x2 = (-b - Math.Sqrt(D)) / (a * 2);
    Console.WriteLine("x1 = {0}", x1);
    Console.WriteLine("x2 = {0}", x2);
}