// See https://aka.ms/new-console-template for more information
Console.WriteLine("Виведення чисел прописом");

Console.WriteLine("------------------------------------");

Console.WriteLine("Введiть число в дiапазонi вiд 0 до 9");

int s = int.Parse(Console.ReadLine());

if (s < 0 || s > 9)
{
    Console.WriteLine("Ви ввели некоректне число!");
}

switch(s)
{
    case 0: 
        Console.WriteLine("Нуль");
        break;
    case 1: 
        Console.WriteLine("Один");
        break;
    case 2:
        Console.WriteLine("Два");
        break;
    case 3:
        Console.WriteLine("Три");
        break;
    case 4:
        Console.WriteLine("Чотири");
        break;
    case 5:
        Console.WriteLine("П'ять");
        break;
    case 6:
        Console.WriteLine("Шiсть");
        break;
    case 7:
        Console.WriteLine("Сiм");
        break;
    case 8:
        Console.WriteLine("Вiсiм");
        break;
    case 9:
        Console.WriteLine("Дев'ять");
        break;
}
