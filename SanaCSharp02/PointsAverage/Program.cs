int PointsCount = 5;
double Point, PointsSum = 0;

for (int i = 0; i < PointsCount; i++)
{
    do
    {
        Console.Write($"{i + 1}) Enter student point: ");
        if (double.TryParse(Console.ReadLine(), out Point) && Point >= 1 && Point <= 5)
            break;
        else
        {
            Console.WriteLine("Something went wrong!");
            Console.Write("Repeat entering student point: ");
        }
    } while (double.TryParse(Console.ReadLine(), out Point) && !(Point >= 1 && Point <= 5)) ;

    PointsSum += Point;
}

double PointsAverage = PointsSum / PointsCount;

Console.WriteLine($"Points sum: {PointsSum}; Points average: {PointsAverage}");

if (PointsAverage >= 4)
    Console.WriteLine("The stundet is admitted to the exam!");
else
    Console.WriteLine("The stundet is not admitted to the exam!");
