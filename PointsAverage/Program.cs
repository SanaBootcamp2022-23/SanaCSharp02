// See https://aka.ms/new-console-template for more information
using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

double sumPoints = 0;

for (int i = 0; i < 5; i++)
{
    bool Ok = false;
    double mark;
    do
    {
        Console.Write($"Введіть {i + 1} оцінку студента -> ");
        Ok = Double.TryParse(Console.ReadLine(), out mark);
    } while (!Ok);
    sumPoints += mark;
}

if (sumPoints / 5.0 >= 4)
{
    Console.WriteLine("Студент допущений до екзамену!");
}
else
{
    Console.WriteLine("Студент не допущений до екзамену!");
}

Console.ReadKey();
