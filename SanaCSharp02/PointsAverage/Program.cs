using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double points, pointsAverage, sumPoints=0;


Console.WriteLine("Введіть 5 оцінок:");
 
for(int i = 0; i < 5; i++)
{
    points = double.Parse(Console.ReadLine());
    sumPoints += points; 
}

pointsAverage = sumPoints / 5;

if(pointsAverage >= 4)
    Console.WriteLine("Студент отримує допуск");

else
    Console.WriteLine("Студент не отримує допуск");
