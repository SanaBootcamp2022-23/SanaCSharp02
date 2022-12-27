using System;

namespace PointsAverage {
    public class Program {
        public static void Main(string[] args) {
            const int pointsNumber = 5;
            double pointsSum = 0;

            for (int i = 1; i <= pointsNumber; ++i) {
                pointsSum += GetPointFromUser($"Enter point number {i}: ");
            }

            Console.WriteLine("Your average point: {0:0.00}", pointsSum / pointsNumber);
            Console.WriteLine((pointsSum / pointsNumber) >= 4.0 ? "Admitted" : "Not admitted");
        }

        public static double GetPointFromUser(string message) {
            double point;

            Console.Write(message);
            while (true) {
                if (!double.TryParse(Console.ReadLine(), out point)) {
                    Console.Write("Error! Not a number. Try again: ");
                    continue;
                }
                if (point < 0) {
                    Console.Write("Error! Point can not be negative. Try again: ");
                    continue;
                }
                return point;
            }
        }
    }
}
