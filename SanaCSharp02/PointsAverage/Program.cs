// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the five point's of student have:");

int sumPoints = 0;

for(int i = 0; i < 5 ; i++)
{
    int studentPoint = int.Parse(Console.ReadLine());
    sumPoints += studentPoint;
}

double avaregePoint = (sumPoints * 1.0) / 5;

if (avaregePoint >= 4)
    Console.WriteLine($"The student is admitted, his avarage point is = {avaregePoint}");
else
    Console.WriteLine($"The student is not admitted, his avarage point is = {avaregePoint}");