using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double summ = 0;

Console.WriteLine("Введіть 5 оцінок студента");

for (int i = 0; i < 5; i++)
{
    Console.Write("Оцінка {0}: ", i + 1);
    double x = double.Parse(Console.ReadLine());
    summ += x;
}

double average = summ / 5;

if (average >= 4)
{
    Console.WriteLine("Студент отримує допуск");
}
else
{
    Console.WriteLine("Недопущено!!!");
}