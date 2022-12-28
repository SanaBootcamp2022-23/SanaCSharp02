using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double sum = 0, averagePoint;

for(int i = 0; i < 5; i++)
{
    Console.Write("Оцінка " + (i + 1) + ": ");
    sum += double.Parse(Console.ReadLine());
}
averagePoint = sum / 5.0;
Console.WriteLine("\nСередній балл: " + averagePoint);
if(averagePoint >= 4)
    Console.WriteLine("Студент допущений до екзамену.");
else
    Console.WriteLine("Студент не допущений до екзамену.");