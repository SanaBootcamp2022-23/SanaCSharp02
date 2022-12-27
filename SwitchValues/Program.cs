// See https://aka.ms/new-console-template for more information
using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
 System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

bool Ok = false;
int number;

do
{
    Console.Write("Введіть ціле число з діапазону [0,9] -> ");
    Ok = int.TryParse(Console.ReadLine(), out number);
} while (!Ok || number > 9 || number < 0);


switch (number)
{
    case 0:
        Console.WriteLine("нуль");
        break;
    case 1:
        Console.WriteLine("один");
        break;
    case 2:
        Console.WriteLine("два");
        break;
    case 3:
        Console.WriteLine("три");
        break;
    case 4:
        Console.WriteLine("чортири");
        break;
    case 5:
        Console.WriteLine("п'ять");
        break;
    case 6:
        Console.WriteLine("шість");
        break;
    case 7:
        Console.WriteLine("сім");
        break;
    case 8:
        Console.WriteLine("вісім");
        break;
    case 9:
        Console.WriteLine("дев'ять");
        break;
    default:
        Console.WriteLine("помилка введення числа!");
        break;
}

Console.ReadKey();
