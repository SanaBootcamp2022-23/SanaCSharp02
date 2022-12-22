using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int num;

num = GetNumber("від 0 до 9 [0;9]");
SwitchValue(num);

int GetNumber(string name)
{
    int number;
    do
    {
        Console.WriteLine($"Введіть число {name}:\n");
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (0 <= number && number <= 9)
                break;
            else
                Console.WriteLine($"Помилка!\n");
        }
        
    } while (true);
    return number;
}

void SwitchValue(int num)
{
    switch (num)
    {
        case 0: Console.WriteLine("0 - Нуль");
            break;
        case 1: Console.WriteLine("1 - Один");
            break;
        case 2: Console.WriteLine("2 - Два");
            break;
        case 3: Console.WriteLine("3 - Три");
            break;
        case 4: Console.WriteLine("4 - Чотири");
            break;
        case 5: Console.WriteLine("5 - П'ять");
            break;
        case 6: Console.WriteLine("6 - Шість");
            break; 
        case 7: Console.WriteLine("7 - Сім");
            break;
        case 8: Console.WriteLine("8 - Вісім");
            break;
        case 9: Console.WriteLine("9 - Девять");
            break;
        default: Console.WriteLine("Помилка!");
            break;

    }
}