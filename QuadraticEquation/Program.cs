using System;

namespace QuadraticEquation {
    public class Program {
        public static void Main(string[] args) {
            double a = GetDoubleNumber("Enter coefficient a: ");
            double b = GetDoubleNumber("Enter coefficient b: ");
            double c = GetDoubleNumber("Enter coefficient c: ");
            Console.WriteLine();

            if (a == 0) {
                Console.WriteLine("Equation is linear, please enter a != 0");
                Environment.Exit(1);
            }

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0) {
                Console.WriteLine("Equation has no real solutions (D < 0)");
                Environment.Exit(0);
            }

            if (Math.Abs(D) <= double.Epsilon * 2) {
                double solution = -b / (2 * a);
                Console.WriteLine("Equation has one real solution: {0:0.00} (D = 0)", solution);
                Environment.Exit(0);
            }
            
            double firstSolution = (-b - Math.Sqrt(D)) / (2 * a);
            double secondSolution = (-b + Math.Sqrt(D)) / (2 * a);

            Console.WriteLine("First solution: {0:0.00}", firstSolution);
            Console.WriteLine("Second solution: {0:0.00}", secondSolution);
        }

        public static double GetDoubleNumber(string message) {
            double number;

            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out number)) {
                Console.Write("Error! Not a number. Try again: ");
            }
            return number;
        }

    }
}
