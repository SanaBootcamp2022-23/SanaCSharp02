class Program
{
    static void Main()
    {
        double mark, sum = 0, average,i = 0, count = 5;
        while (i < count)
        {
            Console.Write("Enter a mark:");
            mark = double.Parse(Console.ReadLine());
            sum += mark;
            i++;
        }
        average = sum / count;
        if (average >= 4)
        {
            Console.WriteLine("\n\nStudent can relax!");
        }
        else
        {
            Console.WriteLine("Student have a trouble!");
        }
    }
}