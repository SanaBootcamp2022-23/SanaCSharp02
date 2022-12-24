
    while (true)
    {
        int n;
        Console.Write("Enter natural n -> ");
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Incorrect value");
            continue;
        }
        if (n < 1)
        {
            Console.WriteLine("Incorrect value");
            continue;
        }


        double res = 0;
        for (int i = 1; i <= n; i++)
        {
            res += (Math.Pow(-1, i)) / (2 * i + 1);
        }
        Console.WriteLine($"a = {res}");

        res = 0;
        for (int i = 1; i <= n; i++)
        {
            res += 1 + 1 / (Math.Pow(i, 2));
        }
        Console.WriteLine($"b = {res}");

        res = 0;
        for (int i = 1; i <= n; i++)
        {
            res += calcFactorial(i);
        }
        Console.WriteLine($"c = {res}");
    }


static int calcFactorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    return number * calcFactorial(number - 1);
}