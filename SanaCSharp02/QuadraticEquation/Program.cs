using System.Runtime.InteropServices;

double a,b,c, D, x1, x2;

Console.WriteLine("Enter value of a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter value of b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Enter a value of c:");
c = double.Parse(Console.ReadLine());

if (a > 0)
{
    D = Math.Pow(b, 2) - 4 * a * c;
    if (D == 0)
    {
        x1 =x2= -D / (2.0 * a);
        Console.WriteLine($"\nThe equatin has one solution: x={x1}, D={D}");
    }
    else if (D > 0)
    {
        x1 = (-b + Math.Sqrt(D)) / (2.0 * a); 
        x2 = (-b - Math.Sqrt(D)) / (2.0 * a);
        Console.WriteLine($"\nThe roots of equation: x1={x1}, x2={x2},D={D}");
    }
    else
    {
        Console.WriteLine("\nThe equation has no solution");
    }

}
else
    Console.WriteLine("The equation has no solution");