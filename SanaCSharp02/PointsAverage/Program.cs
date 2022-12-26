using System;

namespace PointsAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, x5;

            x1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());
            x5 = int.Parse(Console.ReadLine());

            double average = ((float)x1 + x2 + x3 + x4 + x5) / 5;

            if(average >= 4)
            {
                Console.WriteLine($"Student accepted! Average rating: {average}");
            }
            else
                Console.WriteLine($"Student failed learning! Average rating: {average}");

        }
    }
}
