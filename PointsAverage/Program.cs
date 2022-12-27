namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] studentMarks = new int[5];
            float average = 0f;
            bool isSuccess = false;
            for (int i = 0; i < studentMarks.Length; i++)
            {
                while (!isSuccess)
                {
                    try
                    {
                        Console.WriteLine($"Enter {i + 1} student mark");
                        studentMarks[i] = int.Parse(Console.ReadLine());
                        average += studentMarks[i];
                        isSuccess = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                isSuccess = false;
            }
            average /= 5;
            Console.WriteLine(average);
        }
    }
}