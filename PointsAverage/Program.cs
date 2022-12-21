List<int> Grades = new();
int GradeSum = 0;

Console.WriteLine("Введіть оцінки:");
for (int i=0;i<5;i++)
{
    Grades.Add(int.Parse(Console.ReadLine()));
    GradeSum += Grades[i];
}

if (GradeSum / Grades.Count >= 4)
    Console.WriteLine("Студента допущено до екзамену.");
else
    Console.WriteLine("Студента НЕ допущено до екзамену!");
