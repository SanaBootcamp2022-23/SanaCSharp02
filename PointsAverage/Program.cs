using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double avg, sum = 0;
double[] points = new double[4];
int i = 0;

do
{
    points[i] = GetNumber();
    sum += points[i];
    i++;
} while (i < 4);

avg = sum / points.Length;

if(avg >= 4)
    Console.WriteLine("Допуск");
else
    Console.WriteLine("Не допуск");


double GetNumber()
{
    double number;
    do
    {
        Console.WriteLine($"Введіть оцінку:");
        if (!double.TryParse(Console.ReadLine(), out number))
            Console.WriteLine($"Помилка у введені оцінки! Спробуйте ще раз. \nВведіть оцінку:");
        else
        {
            Console.WriteLine($"Оцінку записано!\n");
            break;
        }

    } while (true);
    return number;
}


