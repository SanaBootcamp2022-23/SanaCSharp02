double a, b, c;
Console.WriteLine("Input a:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Input b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Input c:");
c = double.Parse(Console.ReadLine());
double D = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"D=: {D}");
if (D < 0)
    Console.WriteLine("Рівняння не має рішеннь");
if (D > 0)
{
    double X1 = (-b + Math.Sqrt(D)) / (2 * a);
    double X2 = (-c - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"X1=: {X1}");
    Console.WriteLine($"X2=: {X2}");
}
if (D == 0)
{
    double X = -b / (2 * a);
    Console.WriteLine($"X=: {X}");
}
