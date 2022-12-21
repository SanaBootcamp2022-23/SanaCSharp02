using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

double sum = 0;

Console.WriteLine("Введіть 5 оцінок студента через абзац");
for(int i =0 ; i < 5; i++)
    sum += int.Parse(Console.ReadLine());

sum /= 5.0;
Console.WriteLine($"Середній бал студент = {sum}\n");
if (sum < 4)
{
    Console.WriteLine("Студент НЕ допущений до екзаману");
}
else
    Console.WriteLine("Студент допущений до екзаману");