// See https://aka.ms/new-console-template for more information
using System.Text;
System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

bool Ok1 = false, Ok2 = false, Ok3 = false;
double a, b, c;
do
{
    Console.Write("Введіть значення числа a -> ");
    Ok1 = double.TryParse(Console.ReadLine(), out a);
} while (!Ok1);
do
{
    Console.Write("Введіть значення числа b -> ");
    Ok2 = double.TryParse(Console.ReadLine(), out b);
} while (!Ok2);
do
{
    Console.Write("Введіть значення числа c -> ");
    Ok3 = double.TryParse(Console.ReadLine(), out c);
} while (!Ok3);


double D = b * b - 4 * a * c;
Console.WriteLine($"D = {D:f2}");

double x1, x2;

if (D >= 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"Рівняння має два корені: x1 = {x1:f2}, x2 = {x2:f2}");
}
else if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"Рівняння має один корінь x1 = {x1:f2}");
}
else Console.WriteLine("Рівняння коренів не має!");
Console.ReadKey();
