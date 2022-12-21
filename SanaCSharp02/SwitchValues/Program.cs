int Number;

do
{
    Console.Write($"Enter number from 0 to 9: ");
    if (int.TryParse(Console.ReadLine(), out Number) && Number >= 0 && Number <= 9)
        break;
    else
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering number from 0 to 9: ");
    }
} while (int.TryParse(Console.ReadLine(), out Number) && !(Number >= 0 && Number <= 9));

switch (Number)
{
    case 0: Console.WriteLine("You entered Zero!"); break;
    case 1: Console.WriteLine("You entered One!"); break;
    case 2: Console.WriteLine("You entered Two!"); break;
    case 3: Console.WriteLine("You entered Three!"); break;
    case 4: Console.WriteLine("You entered Four!"); break;
    case 5: Console.WriteLine("You entered Fife!"); break;
    case 6: Console.WriteLine("You entered Six!"); break;
    case 7: Console.WriteLine("You entered Seven!"); break;
    case 8: Console.WriteLine("You entered Eight!"); break;
    case 9: Console.WriteLine("You entered Nine!"); break;
    default: Console.WriteLine("Unknown number!"); break;
}