internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0, avg;
        
        int[] estimate = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{i}: ");
            estimate[i] = int.Parse(Console.ReadLine());
            sum += estimate[i];
        }

        avg = sum / 5;

        if (avg >= 4)
        {
            Console.WriteLine($"Admited!");
        }
        else
        {
            Console.WriteLine($"Don't admited.");
        }
    }
}