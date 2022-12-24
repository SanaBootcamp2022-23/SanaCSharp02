Console.OutputEncoding = System.Text.Encoding.UTF8;
int number;

while (true)
{

    Console.Write("Enter a number from 0 to 9 -> ");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    break;
}


switch (number)
{
    case 0:
        Console.WriteLine("0 - нуль");
        break;
    case 1:
        Console.WriteLine("1 - один");
        break;
    case 2:
        Console.WriteLine("2 - два");
        break;
    case 3:
        Console.WriteLine("3 - три");
        break;
    case 4:
        Console.WriteLine("4 - чотири");
        break;
    case 5:
        Console.WriteLine("5 - п'ять");
        break;
    case 6:
        Console.WriteLine("6 - шість");
        break;
    case 7:
        Console.WriteLine("7 - сім");
        break;
    case 8:
        Console.WriteLine("8 - вісім");
        break;
    case 9:
        Console.WriteLine("9 - дев'ять");
        break;
    default:
        Console.WriteLine("Invalid number entered");
        break;
}