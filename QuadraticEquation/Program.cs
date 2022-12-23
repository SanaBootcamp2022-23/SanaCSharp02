Console.WriteLine("Enter a,b,c:");
Console.Write("a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("c = ");
double c = double.Parse(Console.ReadLine());
double D = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"D = {D}");
if(D > 0)
{
    if (a == 0)
    {
        Console.WriteLine($" x = {-c / b}");
    }
    else
    {
        Console.WriteLine($"x1 = {-b + Math.Sqrt(D) / 2 * a}");
        Console.WriteLine($"x2 = {-b - Math.Sqrt(D) / 2 * a}");
    }
} else if(D == 0)
{
    Console.WriteLine($"x = { - b/2 * a}");
}
else
{
    Console.WriteLine("No solutions");
}