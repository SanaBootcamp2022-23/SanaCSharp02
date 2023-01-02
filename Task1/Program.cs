
double a, b, c, D, x1, x2, x;

Console.WriteLine("Enter the coefficients of quadratic equation:");
Console.Write("a=");
a = double.Parse(Console.ReadLine());
Console.Write("b=");
b = double.Parse(Console.ReadLine());
Console.Write("c=");
c = double.Parse(Console.ReadLine());

D = b * b - 4 * a * c;
Console.WriteLine($"\nDiscriminant D = {D:F1}");

if (D < 0) Console.WriteLine("No solutions found");

if (D == 0)
{
    x = (-b) / (2 * a);
    Console.WriteLine($"The root: x = {x,1}");
}
if(D>0)
{
    x1= (-b+ Math.Sqrt(D)) / (2 * a);
    x2= (-b- Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"\nThe roots:\n x1 = {x1:F1}\n x2 = {x2:F1}");
}