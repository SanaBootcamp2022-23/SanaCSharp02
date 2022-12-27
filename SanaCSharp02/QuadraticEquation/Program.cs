// See https://aka.ms/new-console-template for more information
Console.WriteLine("a= ");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("b= ");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("c= ");
var c = double.Parse(Console.ReadLine());

double x1, x2;

var discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
{
    Console.WriteLine("Quadratic equation has no roots");
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
        x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    }
    Console.WriteLine($"x1 = {x1}; x2 = {x2}");
}