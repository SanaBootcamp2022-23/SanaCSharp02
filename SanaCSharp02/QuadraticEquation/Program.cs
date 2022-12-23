using Helpers;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program \"QuadraticEquation\"\n");

            ConsoleReader.MakeCustomSeparator();

            Console.WriteLine("Please enter double input values.");
            var numberA = ConsoleReader.ReadDouble("a");
            var numberB = ConsoleReader.ReadDouble("b");
            var numberC = ConsoleReader.ReadDouble("c");

            var resultModel = MathLibrary.Math.SolveQuadraticEquation(numberA, numberB, numberC);

            Console.WriteLine("\nRESULT:");

            if (resultModel.Discriminator != null)
            {
                Console.WriteLine($"Discriminator: {resultModel.Discriminator}");
            }

            if (resultModel.ErrorMessage != null)
            {
                Console.WriteLine("\nError: " + resultModel.ErrorMessage);
                return;
            }

            if (resultModel.RealRoots != null)
            {
                switch (resultModel.CountOfRoots)
                {
                    case 1:
                        Console.WriteLine($"Root: {Math.Round(resultModel.RealRoots[0], 3)}");
                        break;
                    case 2:
                        Console.WriteLine($"Roots: {Math.Round(resultModel.RealRoots[0], 3)} {Math.Round(resultModel.RealRoots[1], 3)}");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Roots not found.");
            }
        }
    }
}