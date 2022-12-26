using System;

namespace PointsAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double average = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введiть {i + 1} оцiнку: ");
                average += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(average / 5.0 >= 4.0 ? "Студент допущенний до екзамену." : "Студент не допущенний до екзамену.");
        }
    }
}
