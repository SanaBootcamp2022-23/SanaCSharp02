using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; //Для коректного відображення літери "і"

int Value;

do
{
    Console.Write($"Введіть число [0 - 9]: ");
    if (int.TryParse(Console.ReadLine(), out Value) && Value >= 0 && Value <= 9) break;
    else
    {
        Console.Write("Введіть коректне значення [0 - 9]: ");
    }
} while (int.TryParse(Console.ReadLine(), out Value) && !(Value >= 0 && Value <= 9));

switch (Value)
{
    case 0: Console.WriteLine("Нуль"); break;
    case 1: Console.WriteLine("Один"); break;
    case 2: Console.WriteLine("Два"); break;
    case 3: Console.WriteLine("Три"); break;
    case 4: Console.WriteLine("Чотири"); break;
    case 5: Console.WriteLine("П'ять"); break;
    case 6: Console.WriteLine("Шість"); break;
    case 7: Console.WriteLine("Сім"); break;
    case 8: Console.WriteLine("Вісім"); break;
    case 9: Console.WriteLine("Дев'ять"); break;
    default: Console.WriteLine("Якесь дивне у вас число"); break;
}