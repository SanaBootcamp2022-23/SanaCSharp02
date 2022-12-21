using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;


int a, b, c;
double discr;
Console.WriteLine("Маємо квадратне рівняння виду ax^2 + bx + c = 0, де a не дорівнює 0");
Console.Write("Введіть а: ");
a = int.Parse(Console.ReadLine());
while (a == 0)
{
    Console.Write("Введіть а: ");
    a = int.Parse(Console.ReadLine());
}
Console.Write("Введіть b: ");
b = int.Parse(Console.ReadLine());
Console.Write("Введіть c: ");
c = int.Parse(Console.ReadLine());

discr = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"\n D = {discr}");
if (discr > 0)
{
    double x1 = (-b) + discr / 2 * a;
    double x2 = (-b) - discr / 2 * a;
    Console.WriteLine($"\n Результат: x1 = {x1}\n            x2 = {x2}");
}
else if (discr == 0)
{
    double x = (-b) / 2 * a;
    Console.WriteLine($"\n Результат: X = {x}");
}
else Console.WriteLine("\n Розв'язків немає");
