using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
int a;

int enternubmer(out int nubmer)
{
    Console.Write($"Введiть число в діапазоні [0, 9]: ");
    while (!int.TryParse(Console.ReadLine(), out nubmer) || nubmer <= 0 || nubmer >= 9)
    {
        Console.Write($"Невірно введенно число, число має бути цілим і в діапазоні [0, 9] введіть ще раз число: ");
    }
    return nubmer;
}
a = enternubmer(out a);
switch (a)
{
    case 0:
        Console.WriteLine("Нуль");
        break;
    case 1:
        Console.WriteLine("Один");
        break;
    case 2:
        Console.WriteLine("Два");
        break;
    case 3:
        Console.WriteLine("Три");
        break;
    case 4:
        Console.WriteLine("Чотири");
        break;
    case 5:
        Console.WriteLine("П'ять");
        break;
    case 6:
        Console.WriteLine("Шість");
        break;
    case 7:
        Console.WriteLine("Сім");
        break;
    case 8:
        Console.WriteLine("Вісім");
        break;
    case 9:
        Console.WriteLine("Девьять");
        break;
}