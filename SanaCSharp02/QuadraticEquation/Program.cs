using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c, D, x1, x2;

Console.Write("Введіть коефіцієнт a:");
a = double.Parse(Console.ReadLine());

Console.Write("Введіть коефіцієнт b:");
b = double.Parse(Console.ReadLine());

Console.Write("Введіть коефіцієнт c:");
c = double.Parse(Console.ReadLine());

Console.WriteLine("-----результат-----");

if (a == 0)
{
    Console.WriteLine("Рівняння лінійне, а тому:\nx = {0}", x1 = -c / b);
}
else
{
    Console.WriteLine("D = {0}", D = b * b - 4 * a * c);
    if (D > 0)
    {
        Console.WriteLine("x1 = {0}\nx2 = {1}", x1 = (-b - Math.Sqrt(D)) / (2 * a), x2 = (-b + Math.Sqrt(D)) / (2 * a));
    }
    else
    if (D == 0)
    {
        Console.WriteLine("x = {0}", x1 = -b / (2 * a));
    }
    else Console.WriteLine("D < 0\nРівння розв'язків не має.");
}