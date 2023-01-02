using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo customCulture = (CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

int n;
double a=0,b=0, c=0,f;
n = int.Parse(Console.ReadLine());
while(n > 0)
{
    a += Math.Pow(-1, n)/(2*n+1);
    b += 1+(1/Math.Pow(n, 2));
    f = n;
    while(f >= 0)
    {
        c += f;
        f--;
    }
    n--;
}
Console.WriteLine("a:"+a+"\nb:"+b+"\nc:"+c);