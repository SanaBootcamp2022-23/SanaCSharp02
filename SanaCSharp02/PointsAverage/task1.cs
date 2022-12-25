double mark;
int count = 0;
double sum = 0;

while (count < 5)
{
    Console.WriteLine("Введiть оцiнку: ");
    while (!Double.TryParse(Console.ReadLine(), out mark))
    {
        Console.WriteLine("Введено невiрне значення для оцінки!\n Спробуйте ще раз!");
    }

    sum += mark;
    count++;
}

double avgMark = sum / count;
Console.WriteLine($"Середнiй бал студента: {avgMark}");
if(avgMark >= 4)
{
    Console.WriteLine("Студент допущений до екзамену!");
}
else
{
    Console.WriteLine("Студент не допущений до екзамену!");
}