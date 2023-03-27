// See https://aka.ms/new-console-template for more information

Console.WriteLine("Quadratic Equation");

Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("c: ");
double c = Convert.ToDouble(Console.ReadLine());

var d = (Math.Pow(b, 2) - 4 * a * c);
Console.WriteLine($"Discriminator equals: {d}");

if (d > 0)
{    
    var x1 = (-b - Math.Sqrt(d) / 2 * a);
    Console.WriteLine($"x1: {x1}");

    var x2 = (-b + Math.Sqrt(d) / 2 * a);
    Console.WriteLine($"x2: {x2}");
}
else if (d == 0)
{
    var x3 = (-b / (2 * a));
    Console.WriteLine($"x3: {x3}");
}
else
{
    Console.WriteLine("Operation impossible");
}