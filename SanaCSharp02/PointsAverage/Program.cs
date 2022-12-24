int gradesSum = 0;

while (true)
{
    Console.Write("Enter grade -> ");
    int grade;
    if (!int.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    gradesSum += grade;
    break;
}

while (true)
{
    Console.Write("Enter grade -> ");
    int grade;
    if (!int.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    gradesSum += grade;
    break;
}

while (true)
{
    Console.Write("Enter grade -> ");
    int grade;
    if (!int.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    gradesSum += grade;
    break;
}

while (true)
{
    Console.Write("Enter grade -> ");
    int grade;
    if (!int.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    gradesSum += grade;
    break;
}

while (true)
{
    Console.Write("Enter grade -> ");
    int grade;
    if (!int.TryParse(Console.ReadLine(), out grade))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    gradesSum += grade;
    break;
}

double averageGrade = gradesSum / 5f;

if (averageGrade >= 4)
{
    Console.WriteLine($"Your average grade is {String.Format("{0:0.##}", averageGrade)}, you have passed");
}
else
{
    Console.WriteLine($"Your average grade is {String.Format("{0:0.##}", averageGrade)}, you haven't passed");
}