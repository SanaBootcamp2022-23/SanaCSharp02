using System;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student`s marks");
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                double a = Double.Parse(Console.ReadLine());
                sum += a;
            }

            double avg = sum / 5;
            switch (avg)
            {
                case < 4:
                    Console.WriteLine($"No, avg = {avg}");
                    break;
                case > 4:
                    Console.WriteLine($"Yes, avg = {avg}");
                    break;
            }
        }
    }
}
