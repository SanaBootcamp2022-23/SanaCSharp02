double discriminant, x, x1, x2, a, b, c; ;
Console.Write("Enter a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Enter b: ");
b = int.Parse(Console.ReadLine());
Console.Write("Enter c: ");
c = int.Parse(Console.ReadLine());
if (a == 0)
{
    Console.WriteLine("Error");
    return; 
}
else
{
    Console.Write($"Quadratic equation: {a}x + {b}x + {c} = 0\n");
    discriminant = b * b - 4 * a * c;
    Console.Write($"Discriminant = {discriminant}\n");
    if(discriminant == 0)
    {
        x = -b / (2*a);  
    Console.Write($"The equation has one root X = {x}");
    }
    else if (discriminant > 0)
    {
        x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.Write($"The equation has two roots: \nX1={x1}\nX2={x2}");
    }
    else 
    {
        Console.Write("Discriminant < 0. The equation has no solution.");
    }
}