using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

float sum = 0, avg;

for(int i =0; i<5; i++)
{
    int tmp;
    Console.Write($"Введіть {i+1} оцінку: ");
    CheckValuesIsInt(Console.ReadLine(), out tmp);
    sum += tmp;
}
avg = sum / 5;
if (avg >= 4)
{
    Console.WriteLine("Студента допущено до екзамену!");
}
else
{
    Console.WriteLine("Студента не допущенo до екзамену!");
}
Console.WriteLine($"Середній бал студента: {avg:F1}");
Console.ReadKey();




void CheckValuesIsInt(string? s, out int a)
{
    bool fl = false;
    do
    {
        if (!int.TryParse(s, out a))
        {
            Console.WriteLine("\tПомилка! Перевірте введені значення та повторіть введення!");
            s = Console.ReadLine();
        }
        else
        {
            fl = true;
        }
    } while (!fl);
}
