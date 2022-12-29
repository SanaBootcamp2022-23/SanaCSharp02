using System;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter student`s mark :");
            double summary = 0;
            const int ammount = 5;
            for (int i = 0; i < 5; i++)
            {
                double n = Double.Parse(Console.ReadLine());
                summary += n;
            }

            double average = summary / ammount;
            switch (average)
            {
                case < 4:
                    Console.WriteLine($"No, he didn't passed.\n His average is = {average}");
                    break;
                case > 4:
                    Console.WriteLine($"Yes, he passed.\n His average is = {average}");
                    break;
            }
        }
    }
}