int integer;
for (int i = 0; ; i++)
{
    do
    {
        do
        {
            try
            {
                Console.WriteLine($"Enter an integer {i + 1} in the range [0, 9]");
                integer = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input Error");
                Console.ForegroundColor = ConsoleColor.White;
            }

        } while (true);
        if (integer >= 0 && integer <= 9) break;
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input Error");
            Console.ForegroundColor = ConsoleColor.White;
        }

    } while (true);

    switch (integer)
    {
        case 1:
            Console.WriteLine("\tOne");
            break;
        case 2:
            Console.WriteLine("\tTwo");
            break;
        case 3:
            Console.WriteLine("\tThree");
            break;
        case 4:
            Console.WriteLine("\tFour");
            break;
        case 5:
            Console.WriteLine("\tFive");
            break;
        case 6:
            Console.WriteLine("\tSix");
            break;
        case 7:
            Console.WriteLine("\tSeven");
            break;
        case 8:
            Console.WriteLine("\tEight");
            break;
        case 9:
            Console.WriteLine("\tNine");
            break;
        case 0:
            Console.WriteLine("\tZero");
            break;
    }
}
