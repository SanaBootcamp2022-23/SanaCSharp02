// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

bool Ok = false;
int n;
double a = 0, b = 0, c = 0;
int i = 1;

do
{
    Console.Write("Введіть натуральне число n -> ");
    Ok = int.TryParse(Console.ReadLine(), out n);
} while (!Ok || n < 1);

while (i <= n)
{
    a += Math.Pow(-1.0, i) / (2.0 * i + 1);
    b += 1 + (1.0 / Math.Pow(i, 2));

    int var = 1;
    for (int j = 1; j <= i; j++)
    {
        var *= j;
    }
    c += var;
    i += 1;
}

Console.WriteLine($"Число a -> {a}");
Console.WriteLine($"Число b -> {b}");
Console.WriteLine($"Число c -> {c}");

Console.ReadKey();

