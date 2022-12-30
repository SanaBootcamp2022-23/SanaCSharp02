using System.Text.RegularExpressions;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5 чисел");
            int points = 0;
            for (int i = 0; i < 5; i++)
                points += int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"{((points / 5.0) < 4.0 ? "Не д" : "Д")}опускаеться с средней оценкой: {points / 5.0}");
        }
    }
}
