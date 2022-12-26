using System;

double number, c;

Console.Write("Enter number from 0 to 9:");
c = Convert.ToDouble(Console.ReadLine());
switch (c)
{
    case 0:
        Console.Write("zero");
        break;
    case 1:
        Console.Write("one");
        break;
    case 2:
        Console.Write("two");
        break;
    case 3:
        Console.Write("three");
        break;
    case 4:
        Console.Write("four");
        break;
    case 5:
        Console.Write("five");
        break;
    case 6:
        Console.Write("six");
        break;
    case 7:
        Console.Write("seven");
        break;
    case 8:
        Console.Write("eight");
        break;
    case 9:
        Console.Write("nine");
        break;
    default:
        Console.WriteLine("Entered wrong number");
        break;



}