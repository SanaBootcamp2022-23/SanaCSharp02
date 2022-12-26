using System.Reflection;
using System.Text;

Console.OutputEncoding = Encoding.Unicode; 
Console.InputEncoding = Encoding.Unicode;

int[] grades = new int[5];
double sum = 0;
double avg;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Введіть оцінку №{i + 1}");
    grades[i] = int.Parse(Console.ReadLine());
    sum += grades[i];
}

avg = sum / grades.Length;
if (sum >= 4)
{
    Console.WriteLine($"Середня: №{avg}");
    Console.WriteLine("Студента Допущено");
}
else
{
    Console.WriteLine($"Середня: №{avg}");
    Console.WriteLine("Студента не Допущено");
}