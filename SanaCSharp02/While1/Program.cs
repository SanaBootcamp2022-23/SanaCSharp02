using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c;
int n, i;
long fact;
Console.Write("Введіть натуральне n: ");
n = int.Parse(Console.ReadLine());
i = 1;
a = 0;
b = 0;
c = 0;
fact = 1;

while (i <= n)
{
    //a += (Math.Pow(-1, i) / (2 * i + 1.0));
    a += Math.Pow(-1, i) / (2 * i + 1.0);
    b += 1.0 + (1.0 / (Math.Pow(i, 2)));
    fact *= i;
    c += fact;
    i++;    
}

Console.WriteLine($"a = {a}, b = {b}, c = {c}");



