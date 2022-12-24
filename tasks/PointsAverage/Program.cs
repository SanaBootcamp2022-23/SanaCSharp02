using System;

namespace PointsAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double avg, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter mark: ");
                sum += double.Parse(Console.ReadLine());
            }
            avg = sum / 5.0;
            Console.WriteLine($"AVG = {avg}");

            if (avg >= 4)
                Console.WriteLine("Student passed");
            else
                Console.WriteLine("Student not passed");

        }
    }
}
