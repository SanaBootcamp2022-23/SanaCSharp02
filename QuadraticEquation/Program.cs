double a, b, c;
double x1, x2;


Console.Write("Input number a = ");
a = double.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Error! Number a = 0");
    return;
}
    Console.Write("Input number b = ");

b = double.Parse(Console.ReadLine());

Console.Write("Input number c = ");
c = double.Parse(Console.ReadLine());

var discriminant = Math.Pow(b, 2) - 4 * a * c;

if (discriminant < 0)
{
    Console.WriteLine("This quadratic equation has no roots");
}
else
{
    if (discriminant == 0)
    {
        x1 = -b / (2 * a);
        x2 = x1;
    }
    else
    {
        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    }
    Console.WriteLine($"\n x1 = {x1}; \n x2 = {x2}");
}
