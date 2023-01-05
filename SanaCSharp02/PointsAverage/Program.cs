double points, average, summa = 0;
int count = 5;
Console.WriteLine("Enter 5 points: ");
for(int i = 0; i < count; i++)
{
    points = double.Parse(Console.ReadLine());
    summa += points;
}
average = summa / count;
Console.WriteLine($"Sum of points = {summa}");
Console.WriteLine($"Average sum of points is {average}");
if (average >= 4)
{
    Console.WriteLine("Average rating is higher than 4. The student is admitted to the exam");
}
else
{
    Console.WriteLine("Average rating is below than 4. The student is not admitted to the exam");
}