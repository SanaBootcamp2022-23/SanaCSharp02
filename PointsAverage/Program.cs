// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter 5 ratings");
        int a, average, summa = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i + 1} rating: ");
            a = int.Parse(Console.ReadLine());
            if (a > 0 && a <= 5)
                summa += a;
            else
            {
                Console.WriteLine("Error! The number is out of order");
                return;
            }
        }
        average = summa / 5;
        Console.WriteLine($"Average mark {average}");
        if (average >= 4)
            Console.WriteLine("The student has a permit");
        else
            Console.WriteLine("Student does not have access");
    }
}