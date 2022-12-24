namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть 5 оцінок:");

            int[] marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введіть оцінку {i + 1}:");
                marks[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += marks[i];
            }

            double average = (double)sum / 5;
            
            if(average >= 4)
            {
                Console.WriteLine($"Середній бал = {average}");
                Console.WriteLine("Вас допущено до екзамену");
            }
            else
            {
                Console.WriteLine($"Середній бал = {average}");
                Console.WriteLine("Вас не допущено до екзамену");
            }
            
        }
    }
}