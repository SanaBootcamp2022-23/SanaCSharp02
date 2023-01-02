using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = UTF8Encoding.UTF8;

int num, k;

Console.WriteLine("Введіть значення з діапазону [0;9] : ");

for (int i = 0; i < 10; i++)
{
    num = int.Parse(Console.ReadLine());
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

        default:
            Console.WriteLine("Error");
            break;
    }
}