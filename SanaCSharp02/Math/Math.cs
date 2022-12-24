using MathLibrary.Models;

namespace MathLibrary
{
    public static class Math
    {
        public static QuadraticEquationModel SolveQuadraticEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                return new QuadraticEquationModel
                {
                    ErrorMessage = "This equation is linear."
                };
            }

            var discriminator = b * b - (4 * a * c);

            if (discriminator < 0) 
            {
                return new QuadraticEquationModel
                {
                    Discriminator = discriminator,
                    ErrorMessage = "This equation has no real roots."
                };
            }

            var realRoots = new List<double>();
            if (discriminator == 0)
            {
                var root = -b / 2.0 * a;
                realRoots.Add(root);

                return new QuadraticEquationModel
                {
                    RealRoots = realRoots,
                    Discriminator = discriminator,
                    CountOfRoots = 1
                };
            }

            var firstRoot = (-b + System.Math.Sqrt(discriminator)) / (2.0 * a);
            var secondRoot = (-b - System.Math.Sqrt(discriminator)) / (2.0 * a);

            realRoots.Add(firstRoot);
            realRoots.Add(secondRoot);

            return new QuadraticEquationModel 
            {
                CountOfRoots = 2,
                Discriminator = discriminator,
                RealRoots = realRoots 
            };
        }

        public static double CalculateAverage(params double[] numbers)
        {
            var sum = 0.0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            var average = sum / numbers.Length;
            return average;
        }

        public static string GetTextNumber(int number)
        {
            return number switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                0 => "zero",
                _ => ""
            };
        }

        public static ulong Factorial(ulong number)
        {
            if (number == 0) 
                return 1;

            return number * Factorial(number - 1);
        }
    }
}