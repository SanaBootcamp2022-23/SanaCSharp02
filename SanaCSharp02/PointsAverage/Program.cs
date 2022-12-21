using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; //Для коректного відображення літери "і"

int pointsCount = 5;
double point, pointsSum = 0, pointsAvg;

for (int i = 0; i < pointsCount; i++)

{
    do
    {
        Console.Write($"{i + 1}) Введіть оцінку: ");
        if (double.TryParse(Console.ReadLine(), out point) && point >= 1 && point <= 5) break;
        else
        {
            Console.WriteLine("Введіть оцінку від 1 до 5!");
            Console.Write("Введіть коректне значення: ");
        }
        
    } while (double.TryParse(Console.ReadLine(), out point) && !(point >= 1 && point <= 5));

    pointsSum += point;
}

pointsAvg = pointsSum / pointsCount;

Console.WriteLine($"Сума оцінок: {pointsSum}; Середній бал: {pointsAvg}");

if (pointsAvg >= 4)
    Console.WriteLine("Студент отримав доступ до екзамену!");
else
    Console.WriteLine("Студент не отримав доступ до екзамену!");