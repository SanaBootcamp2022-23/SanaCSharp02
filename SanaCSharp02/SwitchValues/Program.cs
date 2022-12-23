

Console.WriteLine("Enter value [0, 9]: ");
try
{
    int value = int.Parse(Console.ReadLine());
    if (value < 0 || value > 9)
    {
        Console.WriteLine("Wrong value. Try once more.");
    }
    else
    {
        string[] values = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.WriteLine($"{value} - {values[value]}");
    }
}
catch (FormatException e)
{
    Console.WriteLine($"Format exception: {e.Message}");
}
