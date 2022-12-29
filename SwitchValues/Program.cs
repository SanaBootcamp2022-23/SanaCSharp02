
int maximum = 9;
int minimum = 0;
Console.Write("Enter number diapason [{0}, {1}] ", minimum, maximum);
int number = Convert.ToInt32(Console.ReadLine());
if (number >= minimum && number <= maximum)
{
    switch (number)
    {
        case 0:
        {
            Console.WriteLine("0 - null");
            break;
        }
        case 1:
        {
            Console.WriteLine("1 - one");
            break;
            }
        case 2:
        {
            Console.WriteLine("2 - two");
            break;
        }
        case 3:
        {
            Console.WriteLine("3 - three");
            break;
        }
        case 4:
        {
            Console.WriteLine("4 - four");
            break;
        }
        case 5:
        {
            Console.WriteLine("5 - five");
            break;
        }
        case 6:
        {
            Console.WriteLine("6 - six");
            break;
        }
        case 7:
        {
            Console.WriteLine("7 - seven");
            break;
        }
        case 8:
        {
            Console.WriteLine("8 - eight");
            break;
        }
        case 9:
        {
            Console.WriteLine("9 - nine");
            break;
        }
        default:
        {
            Console.WriteLine("Unknown error");
            break;
        }
    }
}
else
{
    Console.WriteLine("You write not found number please write number = [{0}, {1}]", minimum, maximum);
}