int num = Convert.ToInt32(Console.ReadLine());


do
{
    Console.WriteLine("Enter number");
}
while (num >= 0 && num <=9);


switch (num)
    {
        case 0:
            Console.WriteLine("Zero");
            break;
        case 1:
            Console.WriteLine("One");
            break;
        case 2:
            Console.WriteLine("Two");
            break;
        case 3:
            Console.WriteLine("T ee");
            break;
        case 4:
            Console.WriteLine("Four");
            break;
        case 5:
            Console.WriteLine("Five");
            break;
        case 6:
            Console.WriteLine("Six");
            break;
        case 7:
            Console.WriteLine("Seven");
            break;
        case 8:
            Console.WriteLine("Eight");
            break;
        case 9:
            Console.WriteLine("Nine");
            break;
        default:
            Console.WriteLine("Try again");
            break;
    }

/*if (num >= 0 && num <= 9)
{
    Console.WriteLine($"Your number is: {num}");
}
else
{
    Console.Write("Enter again: ");
    Console.ReadLine();
    Console.WriteLine($"Second num is: {num}");
      
}*/