using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                      System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int mark1, mark2, mark3, mark4, mark5;

double averagemark;

Console.WriteLine("Введіть 5 оцінок студента для визначення допуску до екзамену!");
Console.Write("Введіть 1 оцінку: ");
mark1 = int.Parse(Console.ReadLine());
Console.Write("Введіть 2 оцінку: ");
mark2 = int.Parse(Console.ReadLine());
Console.Write("Введіть 3 оцінку: ");
mark3 = int.Parse(Console.ReadLine());
Console.Write("Введіть 4 оцінку: ");
mark4 = int.Parse(Console.ReadLine());
Console.Write("Введіть 5 оцінку: ");
mark5 = int.Parse(Console.ReadLine());

averagemark = (mark1 + mark2 + mark3 + mark4 + mark5)/5.0;

if (averagemark > 4)
{
    Console.WriteLine("Студента допущено до екзамену!");
}
else { Console.WriteLine("Студента не допущено до екзамену, на допку!"); }

