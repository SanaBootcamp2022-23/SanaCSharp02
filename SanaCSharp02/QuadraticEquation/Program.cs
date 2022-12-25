using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c, d, x, x1, x2;
Console.WriteLine("Введіть значення числа а:");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення числа b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть значення числа c:");
c = double.Parse(Console.ReadLine());

d = Math.Pow(b, 2) - 4 * a * c;

Console.WriteLine($"Значення d: {d}");

if (d > 0)
{
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine($"Значення x1 = {x1}, x2 = {x2}");
}
if (d == 0)
{
    x = (-b) / (2 * a);
    Console.WriteLine($"Рівняння має один розв'язок = {x}");
}
if (d < 0)
{
    Console.WriteLine($"Оскільки дискримінант менший за нуль, то рівняння не має дійсних рішень");
}