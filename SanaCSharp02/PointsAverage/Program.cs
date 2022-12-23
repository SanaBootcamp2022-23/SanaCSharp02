using Helpers;

namespace PointsAverage
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("The program \"PointsAverage\"\n");

            Console.WriteLine("Please enter count of points.");
            var countOfPoints = ConsoleReader.ReadInt("count");

            Console.WriteLine("\nPlease enter yours points.");
            var points = new double[countOfPoints];
            for (var i = 0; i < countOfPoints; i++)
            {
                points[i] = ConsoleReader.ReadDouble($"{i + 1} point", 0, 5);
            }

            var averagePoint = MathLibrary.Math.CalculateAverage(points);
            Console.WriteLine($"\nYour average point: {Math.Round(averagePoint, 3)}");

            Console.WriteLine(
                !IsAdmitted(averagePoint)
                ? "Your average point is less than 4, so you are not admitted to take the exam."
                : "Your average point is more than 4, so you are admitted to the exam.");
        }

        private static bool IsAdmitted(double point) => point >= 4.0;
    }
}