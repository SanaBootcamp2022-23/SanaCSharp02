// See https://aka.ms/new-console-template for more information
//SanaCShapr02
//Bohdan Serdeniuk

using System.Globalization;

double a, b, c, d, e, PointsAverage;

//dot as separator
CultureInfo customCulture = (CultureInfo)
    Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
Thread.CurrentThread.CurrentCulture = customCulture;

Console.WriteLine("PointsAverage");

//initialization of variables
Console.WriteLine("enter the first value");
a = double.Parse(Console.ReadLine());
Console.WriteLine("enter the second value");
b = double.Parse(Console.ReadLine());
Console.WriteLine("enter the third value");
c = double.Parse(Console.ReadLine());
Console.WriteLine("enter the fourth value");
e = double.Parse(Console.ReadLine());
Console.WriteLine("enter the fifth value");
d = double.Parse(Console.ReadLine());

//calculation of the result and output of the result
PointsAverage = (a + b + c + d + e) / 5;

if (PointsAverage < 4)
{
    Console.WriteLine($"Student's grade point average = {PointsAverage}\nThe student is not admitted");
}
else
{
    Console.WriteLine($"Student's grade point average = {PointsAverage}\nThe student is admitted");
}