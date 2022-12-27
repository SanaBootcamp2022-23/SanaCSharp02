// See https://aka.ms/new-console-template for more information



Console.WriteLine("Choose a language"); 
Console.WriteLine("1-English 2-Українська");
Console.Write("-->"); byte language = byte.Parse(Console.ReadLine());
switch (language)
{
    case 1: {
            Console.WriteLine("Input number in range [0 - 9]");
            Console.Write("-->"); byte number = byte.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("0-Zero");
                    break;
                case 1:
                    Console.WriteLine("1-One");
                    break;
                case 2:
                    Console.WriteLine("2-Two");
                    break;
                case 3:
                    Console.WriteLine("3-Three");
                    break;
                case 4:
                    Console.WriteLine("4-Four");
                    break;
                case 5:
                    Console.WriteLine("5-Five");
                    break;
                case 6:
                    Console.WriteLine("6-Six");
                    break;
                case 7:
                    Console.WriteLine("7-Seven");
                    break;
                case 8:
                    Console.WriteLine("8-Eight");
                    break;
                case 9:
                    Console.WriteLine("9-Nine");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
    }
        break;
     case 2:  {
            Console.WriteLine("Введiть числo з промiжку [0 - 9]");
            Console.Write("-->"); byte number = byte.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("0-Нуль");
                    break;
                case 1:
                    Console.WriteLine("1-Один");
                    break;
                case 2:
                    Console.WriteLine("2-Два");
                    break;
                case 3:
                    Console.WriteLine("3-Три");
                    break;
                case 4:
                    Console.WriteLine("4-Чотири");
                    break;
                case 5:
                    Console.WriteLine("5-П'ять");
                    break;
                case 6:
                    Console.WriteLine("6-Шiсть");
                    break;
                case 7:
                    Console.WriteLine("7-Сiм");
                    break;
                case 8:
                    Console.WriteLine("8-Вiсiм");
                    break;
                case 9:
                    Console.WriteLine("9-Девʼять");
                    break;
                default:
                    Console.WriteLine("Помиилка");
                    break;
            }
     }
        break;
        default:Console.WriteLine("Error");
        break;
}