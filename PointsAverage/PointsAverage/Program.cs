using System;

class Program
{
    public static void Main(string[] args)
    {
        double sum =0, average;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"Enter the {i} mark");
            Console.Write("-> ");
            sum += double.Parse(Console.ReadLine());
        }
        average = sum / 5;
        if (average >= 4)
            Console.WriteLine("dopusk");
        else
            Console.WriteLine("No dopusk");
    }
}