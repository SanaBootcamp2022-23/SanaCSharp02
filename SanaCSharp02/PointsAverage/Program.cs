

Console.WriteLine("Enter grades [1; 5]:");

float averageGrade = 0;
float grade;

for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter grage #{0}:", i + 1);
    if (!float.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Error!!!");
        return;
    }
    if(grade > 0 && grade <= 5)
        averageGrade += grade;
    else
    {
        Console.WriteLine("Enter a rating between 1 and 5!");
        return;
    }
}

averageGrade /= 5;

if (averageGrade >= 4)
{
    Console.WriteLine("Admission to the exam");
}
else Console.WriteLine("No admission to the exam");


