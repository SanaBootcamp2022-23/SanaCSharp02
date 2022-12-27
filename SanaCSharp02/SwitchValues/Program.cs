int a;
Console.WriteLine("Введіть число від 0 до 9");
a = int.Parse(Console.ReadLine());
switch (a)
{
    case 0:
        Console.WriteLine("нуль");
        break;
    case 1:
        Console.WriteLine("oдин");
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
        Console.WriteLine("п`ять");
        break;
    case 6:
        Console.WriteLine("шiсть");
        break;
    case 7:
        Console.WriteLine("сiм");
        break;
    case 8:
        Console.WriteLine("вiсiм");
        break;
    case 9:
        Console.WriteLine("дев`ять");
        break;
}