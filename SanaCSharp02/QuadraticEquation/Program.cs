using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Програма для розв'язання квадратного рівняння");

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c, d, x1, x2, x;

Console.WriteLine("Введіть число a");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число b");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Введіть число c");
c = double.Parse(Console.ReadLine());

d = Math.Pow(b, 2) - 4 * a * c;

if (d > 0)
{
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine(
        $"Перший розв'язок x1= {x1}\n" +
        $"Другий розв'язок x2= {x2}");
}
else if (d == 0)
{
    x = -b / (2 * a);
    Console.WriteLine($"Дискримінант дорівнює 0, тому розв'язок тільки один \n x = {x}");
}
else
{
    Console.WriteLine("Розв'язків немає");
}