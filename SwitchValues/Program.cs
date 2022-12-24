
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int number;

CheckAndWriteNumber(out number);

switch (number)
{
    case 0: { Console.WriteLine($"{number} - нуль"); }break;
    case 1: { Console.WriteLine($"{number} - один"); } break;
    case 2: { Console.WriteLine($"{number} - два"); } break;
    case 3: { Console.WriteLine($"{number} - три"); } break;
    case 4: { Console.WriteLine($"{number} - чотири"); } break;
    case 5: { Console.WriteLine($"{number} - п'ять"); } break;
    case 6: { Console.WriteLine($"{number} - шість"); } break;
    case 7: { Console.WriteLine($"{number} - сім"); } break;
    case 8: { Console.WriteLine($"{number} - вісім"); } break;
    case 9: { Console.WriteLine($"{number} - дев'ять"); } break;
}


void CheckAndWriteNumber(out int number)
{
    bool isRightNumber;
    do
    {
        Console.Write($"Input number: ");
        isRightNumber = int.TryParse(Console.ReadLine(), out number);
        if (number < 0 || number > 9)
            isRightNumber = false;
        if (!isRightNumber)
        {
            Console.Write("ERROR!!!\n");
        }
    } while (!isRightNumber);
}