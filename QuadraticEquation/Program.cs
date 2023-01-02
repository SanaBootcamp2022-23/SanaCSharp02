using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo customCulture = (CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b,c,x1,x2,D;
Console.WriteLine("Введіть a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть b");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть c");
c = double.Parse(Console.ReadLine());
D = Math.Pow(b, 2) - 4 * a * c;
x1 = (-b + D) / (2 * a);
x2 = (-b - D) / (2 * a);
Console.WriteLine( "D:"+D);
if (D > 0)
{
    Console.WriteLine("x1 : "+ x1 + "\nx2: " + x2);
}
else if(D == 0)
{
    Console.WriteLine("x1 : " + x1);
}
else
{
    Console.WriteLine("Дискримінант менше 0");
}
