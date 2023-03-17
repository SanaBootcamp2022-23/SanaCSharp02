double a, b, c, d, x1, x2;
Console.Write("a:");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b:");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("c:");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"{a}x^2 + {b}x + {c} = 0");
d = b * b - 4 * a * c;
Console.WriteLine($"D = {d}");
if (d > 0)
{
    x1 = (-b + Double.Sqrt(d)) / (2 * a);
    Console.WriteLine($"x1 = {x1}");
    x2 = (-b - Double.Sqrt(d)) / (2 * a);
    Console.WriteLine($"x2 = {x2}");
} else if (d == 0)
{
    x1 = -(b / (2 * a));
    Console.WriteLine($"x = {x1}");
} else if (d < 0)
    Console.WriteLine("no answer");
