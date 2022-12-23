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
    }
}