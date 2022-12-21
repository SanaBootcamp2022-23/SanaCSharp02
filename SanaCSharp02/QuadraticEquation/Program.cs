using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; //Для коректного відображення літери "і"

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, Dis, x, x1, x2;

do
{
    Console.Write("Введіть a: ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Введіть коректне значення a: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out a));
do
{
    Console.Write("Введіть b: ");
    if (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Введіть коректне значення b: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out b));
do
{
    Console.Write("Введіть c: ");
    if (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Введіть коректне значення c: ");
    }
    else { break; }
} while (!double.TryParse(Console.ReadLine(), out c));

Dis = b * b - 4 * a * c;
Console.WriteLine($"Дискримінант = {Math.Round(Dis, 3)}");

if (Dis>0)
{
    x1 = (-b + System.Math.Sqrt(Dis)) / (2 * a);
    x2 = (-b - System.Math.Sqrt(Dis)) / (2 * a);
    Console.WriteLine($"x1 = {Math.Round(x1, 3)}");
    Console.WriteLine($"x2 = {Math.Round(x2, 3)}");
}
else if (Dis == 0)
{
    x = -b / (2 * a);
    Console.WriteLine($"x = {Math.Round(x, 3)}");
}
else 
    Console.WriteLine("Дискримінант меньше 0, коренів немає");
