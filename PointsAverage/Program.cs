internal class Program
{
    private static void Main()
    {
        List<int> grades = new(5);
        int gradesSum = 0;

        Console.WriteLine("");
        Console.WriteLine("Enter grades: \n");
        for (int i = 0; i < 5; i++)
        {
            int grade = ParseIntVar($"grade №{i + 1}");
            grades.Add(grade);

            gradesSum += grade;
        }

        double pointsAverage = (double)gradesSum / grades.Count;
        Console.WriteLine($"\nPoints average: {pointsAverage:0.00}");

        Console.WriteLine(
            pointsAverage >= 4
                ? "Student admitted to take exam"
                : "Student is not admitted to take exam"
        );
    }

    private static int ParseIntVar(string varName)
    {
        bool success;
        int result;

        do
        {
            Console.Write($"Insert value for {varName}: ");
            success = int.TryParse(Console.ReadLine(), out result);

            if (!success)
                Console.WriteLine("\nParsing error, try again");
        } while (!success);

        return result;
    }
}
