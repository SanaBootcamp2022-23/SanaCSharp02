Console.WriteLine("Input number a > 0");
double a;
a = double.Parse(Console.ReadLine());
if (a == 0)
{ 
    Console.WriteLine("a < 0");
    return;
}

Console.WriteLine("Input number b");
double b;
b = double.Parse(Console.ReadLine());

Console.WriteLine("Input number c");
double c;
c = double.Parse(Console.ReadLine());

double D;

D = Math.Pow(b, 2) - 4.0 * a * c;
Console.WriteLine($"Discriminant = {D}");

if (D < 0)
    Console.WriteLine("The equation has no real roots");
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"The equation has two equal roots: {x}");
}
else if (D > 0)
{ 
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"The equation has two different roots: {x1} and {x2}");
}


