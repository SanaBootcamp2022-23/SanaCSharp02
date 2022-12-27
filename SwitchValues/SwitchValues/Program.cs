int a;
Console.WriteLine("Enter number from 0 to 9");
a = int.Parse(Console.ReadLine());
switch (a)
{
    case 0:
        Console.WriteLine("0 - нуль");
        break;
    case 1:
        Console.WriteLine("1 - oдин");
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
        Console.WriteLine("5 - п`ять");
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
        Console.WriteLine("9 - дев`ять");
        break;
}