double point, average, summa = 0;
Console.WriteLine("Enter 5 points: ");
for (int i = 0; i < 5; i++)
{
    do
    {
        Console.Write($"Input value for point number {i+1}, while 0 <= point <= 5\npoint value = ");
    } while (!double.TryParse(Console.ReadLine(), out point) || point < 0 || point > 5);
    summa += point;
}
average = summa / 5.0;
Console.WriteLine($"Sum of points = {summa}\nAverage point = {average}");
if (average >= 4)
{
    Console.WriteLine("Average rating is higher than 4. The student is admitted to the exam");
}
else
{
    Console.WriteLine("Average rating is below than 4. The student is not admitted to the exam");
}