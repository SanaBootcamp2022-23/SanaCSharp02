using System.Text.RegularExpressions;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел");

            List<int> points = new();

            for (int i = 0; i < 5; i++)
                points.Add(int.Parse(Console.ReadLine() ?? ""));

            var average = points.Average();

            Console.WriteLine($"{(average < 4.0 ? "Не д" : "Д")}опускаеться с средней оценкой: {average}");

        }
    }
}