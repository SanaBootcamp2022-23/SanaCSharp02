double a, b, c;

Console.Write("Enter the \"a\":");
if(!double.TryParse(Console.ReadLine(), out a)) return;
Console.Write("Enter the \"b\":");
if (!double.TryParse(Console.ReadLine(), out b)) return;
Console.Write("Enter the \"c\":");
if (!double.TryParse(Console.ReadLine(), out c)) return;
Console.WriteLine("You entered such a quadratic equation:" +
    $"\n{a}x^2+{b}x+{c} = 0");
double D;
D = b * b - 4 * a * c;
Console.WriteLine($"Discriminant = {D}");
if (D >= 0)
{
    double x1=0, x2=0;
    bool twoRoots = false;
    if (D > 0)
    {
        twoRoots = true;
        x1 = (-b + Math.Sqrt(D)) / (a * 2);
        x2 = (-b - Math.Sqrt(D)) / (a * 2);
    }
    else
        x1 = (-b + Math.Sqrt(D)) / (a * 2);
    Console.WriteLine($"x1 = {x1}");
    if(twoRoots)
        Console.WriteLine($"x2 = {x2}");
    else
        Console.WriteLine("Equation have only one root.");
}
else
    Console.WriteLine("Your equation haven't roots");
