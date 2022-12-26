int value;
Console.WriteLine("Please, enter value from [0,9]");

value = enterData();

switch (value)
{
    case 0:
        Console.WriteLine("нуль");
        break;
    case 1:
        Console.WriteLine("один");
        break;
    case 2:
        Console.WriteLine("два");
        break;
    case 3:
        Console.WriteLine("три");
        break;
    case 4:
        Console.WriteLine("чотири");
        break;
    case 5:
        Console.WriteLine("п'ять");
        break;
    case 6:
        Console.WriteLine("шість");
        break;
    case 7:
        Console.WriteLine("сім");
        break;
    case 8:
        Console.WriteLine("вісім");
        break;
    case 9:
        Console.WriteLine("дев'ять");
        break;
}
int enterData()
{
    string consoleString = Console.ReadLine();
    return int.Parse(consoleString);
}
