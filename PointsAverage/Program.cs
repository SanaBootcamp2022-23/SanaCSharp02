using System.Globalization;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
CultureInfo customCulture = (CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double sum=0,avg;
string[] arrayPoints = Console.ReadLine().Split(' ');
foreach (string point in arrayPoints)
{
    sum += double.Parse(point);
}
avg = sum/arrayPoints.Length;
Console.WriteLine(avg);
if (avg >= 4)
{
    Console.WriteLine("Допущено до екзамену");
}
else
{
    Console.WriteLine("Недопущено до екзамену");
}


