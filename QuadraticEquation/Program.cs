using System.Security.Cryptography;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a, b, c;
bool ok;
    do
    {
        Console.Write("Введіть значення a = ");
        ok = double.TryParse(Console.ReadLine(), out a);
        if (!ok)
            Console.WriteLine("Помилка введення значення a. Будь-ласка повторіть вдення значення ще раз!");
    } while (!ok);
    do
    {
        Console.Write("Введіть значення b = ");
        ok = double.TryParse(Console.ReadLine(), out b);
        if (!ok)
            Console.WriteLine("Помилка введення значення b. Будь-ласка повторіть вдення значення ще раз!");
    } while (!ok);
    do
    {
        Console.Write("Введіть значення c = ");
        ok = double.TryParse(Console.ReadLine(), out c);
        if (!ok)
            Console.WriteLine("Помилка введення значення c. Будь-ласка повторіть вдення значення ще раз!");
    } while (!ok);
    if (a != 0) { 
        double d = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine("Результат обчислення: d = {0:F3}", d);
        Console.ReadKey();
        if (d == 0)
        {
            double x1 = -b / (2 * a);
            Console.WriteLine("Результат обчислення: x1 = {0:F3}", x1);
        }
        else if (d > 0)
        {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("Результат обчислення: x1 = {0:F3}", x1);
            Console.WriteLine("Результат обчислення: x2 = {0:F3}", x2);
        }
        else
        {
            Console.WriteLine("Рівняння немає розв'язку");
        }
    }
    else
    {
        Console.WriteLine("Значення a=0, рівняння не є квадратним!");
    }
Console.ReadKey();
