using Helpers;

namespace SwitchValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program \"SwitchValues\"");

            while (true)
            {
                Console.WriteLine("\nPlease input integer number in the range [0-9].");
                var number = ConsoleReader.ReadInt("number", 0, 9);

                var numberText = MathLibrary.Math.GetTextNumber(number);
                Console.WriteLine($"\nResult: {numberText}");

                Console.WriteLine("\nContinue? 1 - Yes; 0 - No");
                var continueNumber = ConsoleReader.ReadInt("continue", 0, 1);

                if (continueNumber != 1)
                    break;
            }
        }
    }
}