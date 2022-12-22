int IntInput(string text)
{
    bool check = false;
    int val = 0;
    while (!check || val < 0 || val > 9)
    {
        Console.Write(text);
        check = int.TryParse(Console.ReadLine(), out val);
        if (!check || val < 0 || val > 9)
        {
            Console.WriteLine("Incorect input, you must input a number from 0 to 9.");
        }
    }
    return val;
}

bool again = true;

while(again)
{
    int tmpNumber = IntInput("your number = ");
    switch(tmpNumber)
    {
        case 0:
            {
                Console.WriteLine("You entered 'zero'");
                break;
            }
        case 1:
            {
                Console.WriteLine("You entered 'one'");
                break;
            }
        case 2:
            {
                Console.WriteLine("You entered 'two'");
                break;
            }
        case 3:
            {
                Console.WriteLine("You entered 'three'");
                break;
            }
        case 4:
            {
                Console.WriteLine("You entered 'four'");
                break;
            }
        case 5:
            {
                Console.WriteLine("You entered 'five'");
                break;
            }
        case 6:
            {
                Console.WriteLine("You entered 'six'");
                break;
            }
        case 7:
            {
                Console.WriteLine("You entered 'seven'");
                break;
            }
        case 8:
            {
                Console.WriteLine("You entered 'eight'");
                break;
            }
        case 9:
            {
                Console.WriteLine("You entered 'nine'");
                break;
            }
    }

    bool check = false;
    while (!check)
    {
        Console.WriteLine("\nwrite number again?");
        Console.WriteLine("y = yes | n = no");
        string? val = Console.ReadLine();
        if (val == "y")
        {
            again = true;
            check = true;
        }
        else if (val == "n")
        {
            again = false;
            check = true;
        }
        else
        {
            Console.WriteLine("Incorect input.");
        }
    }
}