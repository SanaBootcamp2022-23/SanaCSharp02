float a, b, c, d, x1, x2;

Console.Write("Enter value a: ");
while (!float.TryParse(Console.ReadLine(), out a))
{
    Console.Write("Invalid value, Try again: ");
}

Console.Write("Enter value b: ");
while (!float.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Invalid value, Try again: ");
}

Console.Write("Enter value c: ");
while (!float.TryParse(Console.ReadLine(), out c))
{
    Console.Write("Invalid value, Try again: ");
}
d = (float)(Math.Pow(b, 2) - 4 * a * c);
Console.WriteLine(d);
if (d < 0)
{
    Console.WriteLine("No valid roots");
}
else if (d == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"x1 = {x1}");
}
else if (d>0)
{
    x1 = (float)((-b+Math.Sqrt(d)) / (2 * a));
    x2 = (float)((-b-Math.Sqrt(d)) / (2 * a));
    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}