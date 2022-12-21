using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

int a, b, c;
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
Console.Write("b = ");
b = int.Parse(Console.ReadLine());
Console.Write("c = ");
c = int.Parse(Console.ReadLine());

double d = Math.Pow(b, 2) - 4 * a * c;
double x1, x2;

if (d > 0)
{
    x1 = (-1.0 * b + Math.Sqrt(d)) / (2 * a);
    x2 = (-1.0 * b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"Квадратне рівняння має 2 розв'язки\nx1 = {x1}\nx2 = {x2}");
}
else if (d == 0)
{
    x1 = -1.0 * b + Math.Sqrt(d);
    Console.WriteLine($"Квадратне рівняння має 1 розв'язок\nx1 = {x1}");
}
else
    Console.WriteLine("Квадратне рівняння не має розв'язків");