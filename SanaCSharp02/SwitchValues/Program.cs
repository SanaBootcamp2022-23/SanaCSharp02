
Console.WriteLine("Enter number [0, 9]:");

sbyte number;
if(!sbyte.TryParse(Console.ReadLine(), out number))
{
    Console.WriteLine("Error! Enter number");
    return;
}

switch(number)
{
    case 0: Console.WriteLine("0 zero"); break;
    case 1: Console.WriteLine("1 one"); break;
    case 2: Console.WriteLine("2 two"); break;
    case 3: Console.WriteLine("3 three"); break;
    case 4: Console.WriteLine("4 four"); break;
    case 5: Console.WriteLine("5 five"); break;
    case 6: Console.WriteLine("6 six"); break;
    case 7: Console.WriteLine("7 seven"); break;
    case 8: Console.WriteLine("8 eight"); break;
    case 9: Console.WriteLine("9 nine"); break;
    default: Console.WriteLine("Please enter a number from 0 to 9!"); break;
}

