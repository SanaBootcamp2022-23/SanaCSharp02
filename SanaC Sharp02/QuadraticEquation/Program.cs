int a, b, c;
Console.WriteLine("Enter 3 digits:");
Console.Write("A = ");
a = int.Parse(Console.ReadLine());
Console.Write("B = ");
b = int.Parse(Console.ReadLine());
Console.Write("C = ");
c = int.Parse(Console.ReadLine());
int d;
d = b * b - 4 * a * c;
double x1, x2;
if (d > 0)
{
    x1 = -b + Math.Sqrt(d) / (2 * a);
    x2 = -b - Math.Sqrt(d) / (2 * a);
    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
}
if (d == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"x1 = {x1}");
}
if (d < 0)
{
    Console.WriteLine("Error! D < 0");
}