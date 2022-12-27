Console.OutputEncoding = System.Text.Encoding.Default;

// Ввід оцінок студента
Console.WriteLine("Введіть оцінки студента:");
int grade1 = int.Parse(Console.ReadLine());
int grade2 = int.Parse(Console.ReadLine());
int grade3 = int.Parse(Console.ReadLine());
int grade4 = int.Parse(Console.ReadLine());
int grade5 = int.Parse(Console.ReadLine());

// Підрахунок середнього бала
double averageGrade = (grade1 + grade2 + grade3 + grade4 + grade5) / 5.0;

// Перевірка, чи допущений студент до екзамену
if (averageGrade >= 4)
{
    Console.WriteLine("Студент допущений до екзамену. Середній бал: {0}", Math.Round(averageGrade, 2));
}
else
{
    Console.WriteLine("Студент не допущений до екзамену. Середній бал: {0}", Math.Round(averageGrade, 2));
}