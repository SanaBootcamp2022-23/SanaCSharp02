using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int totalPoints = 0;
double average = 0;

Console.WriteLine("Введіть 5 оцінок для розрахунку середнього балу:");

for(int i = 1; i <= 5; i++)
{
    Console.Write($"Оцінка {i} - ");
    totalPoints += Convert.ToInt32(Console.ReadLine());
}

average = totalPoints / 5.0;

if (average >= 4)
{
    Console.WriteLine($"\nСтудент допущений до екзамену.\nСередній  бал  = {average}");
}
else
{
    Console.WriteLine($"\nСтудент НЕ допущений до екзамену.\nСередній  бал  = {average}");
}
