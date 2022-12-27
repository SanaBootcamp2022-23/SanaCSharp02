using System.Text;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            const int countOfPoints = 5;
            bool isOk;
            double point, totalSumOfPoints = 0, averagePoint;
            for (int i = 0; i < countOfPoints; i++)
            {
                do
                {
                    Console.Write($"Введіть {i + 1} оцінку студента: ");
                    isOk = double.TryParse(Console.ReadLine(), out point);
                    if (!isOk || point <= 0)
                        Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
                } while (!isOk || point <= 0);
                totalSumOfPoints += point;
            }
            averagePoint = totalSumOfPoints / countOfPoints;
            if (averagePoint >= 4)
                Console.WriteLine($"Студент отримує допуск до екзамену\nСередній бал: {averagePoint}");
            else
                Console.WriteLine($"Студент не отримує допуск до екзамену\nСередній бал: {averagePoint}");
        }
    }
}