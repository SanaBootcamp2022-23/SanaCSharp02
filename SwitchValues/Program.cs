// See https://aka.ms/new-console-template for more information
Console.WriteLine("Число у словах");
Console.WriteLine("Введіть число в діапазоні [0, 9]:");

int number = int.Parse(Console.ReadLine());

string numberInWords;
switch (number)
{
    case 0:
        numberInWords = "нуль";
        break;
    case 1:
        numberInWords = "один";
        break;
    case 2:
        numberInWords = "два";
        break;
    case 3:
        numberInWords = "три";
        break;
    case 4:
        numberInWords = "чотири";
        break;
    case 5:
        numberInWords = "п'ять";
        break;
    case 6:
        numberInWords = "шість";
        break;
    case 7:
        numberInWords = "сім";
        break;
    case 8:
        numberInWords = "вісім";
        break;
    case 9:
        numberInWords = "дев'ять";
        break;
    default:
        numberInWords = "недійсне";
        break;
}

Console.WriteLine(numberInWords);
Console.ReadLine();
