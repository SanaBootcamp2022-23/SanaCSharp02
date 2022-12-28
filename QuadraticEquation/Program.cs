using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int a, b, c;
double D, x1, x2;
Console.Write("Введіть число a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введіть число b: ");
b = int.Parse(Console.ReadLine());
Console.Write("Введіть число c: ");
c = int.Parse(Console.ReadLine());

D = Math.Pow(b, 2) - 4 * a * c;
x1 = (-b + Math.Sqrt(D)) / 2 * a;
x2 = (-b - Math.Sqrt(D)) / 2 * a;

Console.WriteLine("\nD = " + D + "\n");

if (D == 0)
    Console.WriteLine("x = " + x1);
else if (D > 0)
{
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
else
    Console.WriteLine("Коренів немає.");

