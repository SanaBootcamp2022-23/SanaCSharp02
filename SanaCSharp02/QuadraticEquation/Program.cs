double a, b, c, x1, x2, x, disc;
Console.Write("Enter a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Enter c: ");
c = double.Parse(Console.ReadLine());
if (a == 0 || b == 0)
{
    Console.WriteLine("Invalid values");
}
else
{
    disc = Math.Sqrt(b * b - 4 * a * c);
    Console.WriteLine($"Discriminant: {disc}");
    if (disc > 0)
    {
        x1 = (-b + disc) / (2 * a);
        Console.WriteLine($"First root: {x1}");
        x2 = (-b - disc) / (2 * a);
        Console.WriteLine($"Second root: {x2}");
    }
    else if (disc == 0)
    {
        x = -b / (2 * a);
        Console.WriteLine($"Root: {x}");
    }
    else
    {
        Console.WriteLine("Zero roots");
    }
}
