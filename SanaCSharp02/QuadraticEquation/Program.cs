﻿using static System.Math;
int a, b, c;
Console.Write("enter a:");
a = int.Parse(Console.ReadLine());
Console.Write("enter b:");
b = int.Parse(Console.ReadLine());
Console.Write("enter c:");
c = int.Parse(Console.ReadLine());
double d = b * b - 4 * a * c;
Console.WriteLine($"D: {d}");
if (d > 0)
{
    double x1 = (-b + Sqrt(d)) / (2 * a);
    double x2 = (-b - Sqrt(d)) / (2 * a);
    Console.WriteLine($"x1: {x1:F2}\nx2: {x2:F2}");
}
else if (d == 0)
{
    double x1 = (-b + Sqrt(d)) / (2 * a);
    Console.WriteLine($"x1: {x1:F2}");
}
else
{
    Console.WriteLine("Рівняння розв'язків не має!");
}
