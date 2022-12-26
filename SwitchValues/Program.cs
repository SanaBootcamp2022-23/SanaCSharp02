using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть число в діапазоні [0-9]");
int num = int.Parse(Console.ReadLine());
    if (num >= 0 && num <= 9)
    {
        switch (num)
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
                Console.WriteLine("Дев'ять");
                break;
        }
    }
    else
    {
        Console.WriteLine("Введене значення поза дозволеним діапазоном!");
    }