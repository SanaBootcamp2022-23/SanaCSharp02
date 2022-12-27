// See https://aka.ms/new-console-template for more information
//SanaCShapr02
//Bohdan Serdeniuk

using System.Globalization;

double a, b, c, d, x1, x2;

//dot as separator
CultureInfo customCulture = (CultureInfo)
    Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("QuadraticEquation\na*x^2 + b*x + c = 0 , where a is not equal to 0");

//initialization of variables
Console.WriteLine("enter the number a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("enter the number c");
c = double.Parse(Console.ReadLine());

//calculation of the result and output of the result
d = Math.Pow(b, 2.0) - 4 * a * c;

if(d < 0)
{
    Console.WriteLine("the equation has no solutions");
}
else
{
    Console.WriteLine($"D = {d}");
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    
    if (x1 >= 0)
    {
        Console.WriteLine($"x1 = {x1}");
    }
    
    if (x2 >= 0)
    {
        Console.WriteLine($"x2 = {x2}");
    }

    if (x1 < 0 && x2 < 0)
    {
        Console.WriteLine("the equation has no solutions");
    }
}