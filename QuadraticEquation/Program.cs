using System;
using static System.Math;

double a, b, c, D, x1, x2;

Console.WriteLine("Enter a = ");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter b = ");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter c = ");
c = Convert.ToDouble(Console.ReadLine());

D = b * b - 4 * a * c;

if (D < 0)
{
    Console.WriteLine("The quadratic equation has no roots");
}
else if (D == 0)
{
    x1 = (-b + Sqrt(D)) / (2 * a);
    Console.WriteLine("The quadratic equation has one root\nx={0}\n", x1);
}
else
{
    x1 = (-b + Sqrt(D)) / (2 * a);
    x2 = (-b - Sqrt(D)) / (2 * a);
    Console.WriteLine("The quadratic equation has two roots\nx1={0}\nx2={1}", x1, x2);
}