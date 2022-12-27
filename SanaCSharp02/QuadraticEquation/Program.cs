Console.WriteLine("Solution of a quadratic equation of the form ax2 + bx + c = 0");

double a, b, c;
Console.Write("a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("c = ");
c = Convert.ToDouble(Console.ReadLine());

double x1, x2;

double discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
{
    Console.WriteLine("A quadratic equation has no roots");
}
else
{
    if (discriminant == 0)
    {
        x1 = -b / (2 * a);
        Console.WriteLine($"Discriminant = {discriminant}; x = {x1};");
    }
    else 
    {
        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine($"Discriminant = {discriminant}; x1 = {x1}; x2 = {x2}");
    }
}
