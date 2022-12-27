Console.OutputEncoding = System.Text.Encoding.Default;

// Введення числа
Console.WriteLine("Введіть число від 0 до 9:");
int number = int.Parse(Console.ReadLine());

// Перетворення числа в рядок
string numberText = "";
switch (number)
{
    case 0:
        numberText = "нуль";
        break;
    case 1:
        numberText = "один";
        break;
    case 2:
        numberText = "два";
        break;
    case 3:
        numberText = "три";
        break;
    case 4:
        numberText = "чотири";
        break;
    case 5:
        numberText = "п’ять";
        break;
    case 6:
        numberText = "шість";
        break;
    case 7:
        numberText = "сім";
        break;
    case 8:
        numberText = "вісім";
        break;
    case 9:
        numberText = "дев’ять";
        break;
    default:
        Console.WriteLine("Введено некорректне число");
        return;
}

// Вивід результату
Console.WriteLine(numberText);