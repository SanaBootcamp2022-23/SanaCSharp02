// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
Encoding utf8 = Encoding.UTF8;

Console.WriteLine("Hello, World!");
// D = b*b - 4ac
//x1,2 = (-b +/- корінь квадратний з D) / 2a

int a, b, c;
double discriminant, x1, x2;

Console.Write("Введіть число а ");
a = int.Parse(Console.ReadLine());
Console.Write("Введіть число b ");
b = int.Parse(Console.ReadLine());
Console.Write("Введіть число c ");
c = int.Parse(Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("Error");
}
else
{
    Console.WriteLine("the answer is:");
}

discriminant = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(discriminant) / (2 * a));
x2 = (-b - Math.Sqrt(discriminant) / (2 * a));

if (discriminant > 0)
{
    Console.WriteLine($"x1= {x1}");
    Console.WriteLine($"x2= {x2}");
}
else if (discriminant == 0)
{
    Console.WriteLine($"x1= {x1}");
}
else
{
    Console.WriteLine("рівняння рішень не має");
}

