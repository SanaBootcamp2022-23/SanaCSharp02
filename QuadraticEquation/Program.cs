// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

int a, b, c;
int discriminant;
double x1, x2;
Console.Write("Input a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Input b: ");
b = int.Parse(Console.ReadLine());
Console.Write("Input c: ");
c = int.Parse(Console.ReadLine());
discriminant = (b * b) - 4 * a * c;
x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
Console.WriteLine("\nResult:");
if (discriminant > 0) Console.WriteLine($"Discriminant = {discriminant}\nx1 = {x1} \nx2 = {x2}");
if (discriminant == 0) Console.WriteLine($"Discriminant = {discriminant}\nx = {x1}");
else if (discriminant < 0) Console.WriteLine("Error: Discriminant < 0");
