Console.Write("Введіть n (0-9):");
int n;
n = Convert.ToInt32(Console.ReadLine());

switch (n)
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
        Console.WriteLine("5 - п’ять");
        break;
    case 6:
        Console.WriteLine("6 - шiсть");
        break;
    case 7:
        Console.WriteLine("7 - сiм");
        break;
    case 8:
        Console.WriteLine("8 - вiсiм");
        break;
    case 9:
        Console.WriteLine("9 - дев’ять");
        break;
    default:
        Console.WriteLine("Введіть число у діапазоні від 0 до 9!");
        break;
}