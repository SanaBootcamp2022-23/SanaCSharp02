using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int num;
Console.Write("Введіть число від 0 до 9: ");
CheckValue(Console.ReadLine(), out num);
switch (num)
{
    case 0:
        Console.WriteLine($"{num} - нуль");
        break;
    case 1:
        Console.WriteLine($"{num} - один");
        break;
    case 2:
        Console.WriteLine($"{num} - два");
        break;
    case 3:
        Console.WriteLine($"{num} - три");
        break;
    case 4:
        Console.WriteLine($"{num} - чотири");
        break;
    case 5:
        Console.WriteLine($"{num} - п'ять");
        break;
    case 6:
        Console.WriteLine($"{num} - шість");
        break;
    case 7:
        Console.WriteLine($"{num} - сім");
        break;
    case 8:
        Console.WriteLine($"{num} - вісім");
        break;
    case 9:
        Console.WriteLine($"{num} - дев'ять");
        break;
}

Console.ReadKey();


void CheckValue(string? s, out int a)
{
    bool fl = false;
    do
    {
        if (!int.TryParse(s, out a) || (a<0 || a>=10))
        {
            Console.Write("\tПомилка!\nПеревірте введені значення та повторіть введення: ");
            s = Console.ReadLine();
        }
        else
        {
            fl = true;
        }
    } while (!fl);
}