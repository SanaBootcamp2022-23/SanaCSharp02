ushort value=0;
while (true) { 
Console.Write("Enter the value in range [0;9] or [10] for exit: ");
if (!ushort.TryParse(Console.ReadLine(), out value)) return;
    switch (value)
    {
        case 0:
            Console.WriteLine("Ноль");
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
            Console.WriteLine("Шість");
            break;
        case 7:
            Console.WriteLine("Сім");
            break;
        case 8:
            Console.WriteLine("Вісім");
            break;
        case 9:
            Console.WriteLine("Дев'ять");
            break;
        default:
            Console.WriteLine("Ви вийшли з програми");
            return;
    }
}