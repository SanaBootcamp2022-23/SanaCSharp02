// See https://aka.ms/new-console-template for more information
//SanaCShapr02
//Bohdan Serdeniuk

//initialization of variables
Console.WriteLine("enter an integer number in the range [0, 9]");
byte a = byte.Parse(Console.ReadLine());

//calculation of the result and output of the result
switch (a)
{
    case 0:
        Console.WriteLine($"{a} - нуль");
        break;

    case 1:
        Console.WriteLine($"{a} - один");
        break;

    case 2:
        Console.WriteLine($"{a} - два");
        break;

    case 3:
        Console.WriteLine($"{a} - три");
        break;

    case 4:
        Console.WriteLine($"{a} - чотири");
        break;

    case 5:
        Console.WriteLine($"{a} - п'ять");
        break;

    case 6:
        Console.WriteLine($"{a} - шість");
        break;

    case 7:
        Console.WriteLine($"{a} - сім");
        break;

    case 8:
        Console.WriteLine($"{a} - вісім");
        break;

    case 9:
        Console.WriteLine($"{a} - дев'ять");
        break;
        
    default:
        Console.WriteLine($"{a} is out of range");
        break;
}