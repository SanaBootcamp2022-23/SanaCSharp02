internal class Program
{
    private static void Main()
    {
        double a, b, c;
        a = b = c = 0;

        Console.WriteLine("");
        int n = ParseIntVar(nameof(n));

        // for (int i = 1; i <= n; i++)
        // {
        //     a += Math.Pow(-1, i) / (2 * i + 1);
        //     b += 1 + (1 / Math.Pow(i, 2));
        //     c += Factorial(i);
        // }

        int i = 1;
        while (i <= n)
        {
            a += Math.Pow(-1, i) / (2 * i + 1);
            b += 1 + (1 / Math.Pow(i, 2));
            c += Factorial(i);

            i++;
        }

        Console.WriteLine();
        Console.WriteLine($"a = {a:0.000}");
        Console.WriteLine($"b = {b:0.000}");
        Console.WriteLine($"c = {c:0.000}");
    }

    private static int Factorial(int n)
    {
        return n == 0
            ? 1
            : n * Factorial(n - 1);
    }

    private static int ParseIntVar(string varName)
    {
        bool success;
        int result;

        do
        {
            Console.Write($"Insert value for {varName}: ");
            success = int.TryParse(Console.ReadLine(), out result);

            if (!success)
                Console.WriteLine("\nParsing error, try again");
        } while (!success);

        return result;
    }
}
