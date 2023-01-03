

using System;




Console.OutputEncoding = System.Text.Encoding.Default;

Console.Write("Введіть а: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введіть c: ");
double c = Convert.ToDouble(Console.ReadLine());

double D, x1, x2;
D = b * b - 4 * a * c;

if (D < 0)
{
    Console.Write("Рішення не існує");
}
else if (D == 0)
{

    x1 = -b / (2 * a);
    Console.Write($"Існує 1 корінь x= {x1}");
}
else
{
    x1 = (-b + Math.Sqrt(D)) / 2 * a;
    x2 = (-b - Math.Sqrt(D)) / 2 * a;
    Console.Write($"Існує 2 кореня\n x1={x1}\n x2={x2}");

}
Console.Read();

