// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть a, b ,c!");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

double d = b * b - 4 * a * c;
Console.WriteLine($"D = {d}");

if (d < 0)
{
    Console.WriteLine("Коренів немає");
}
else if (d == 0)
{
    var x = (-b) / 2 * a;
    Console.WriteLine($"x= {x}");
}
else
{
    var x1 = (-b + Math.Sqrt(d)) / 2 * a;
    var x2 = (-b - Math.Sqrt(d)) / 2 * a;
    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
}