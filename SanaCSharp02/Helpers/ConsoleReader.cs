namespace Helpers
{
    public static class ConsoleReader
    {
        public static double ReadDouble(string label)
        {
            double number;

            Console.Write($"\"{label}\" = ");
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"Error! The number \"{label}\" is not correct!");
                Console.Write($"Please repeat entering a double value.\n\n\"{label}\" = ");
            }

            return number;
        }

        public static void MakeCustomSeparator()
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}