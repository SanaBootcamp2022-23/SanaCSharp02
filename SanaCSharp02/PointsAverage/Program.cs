

Console.WriteLine("Введіть 5 оцінок студента");
double sum = 0;
for (int i = 0; i < 5; i++)
{
    double a = Convert.ToDouble(Console.ReadLine());
    sum += a;
}

double avg = sum / 5;
switch (avg)
{
    case < 4:
        Console.WriteLine($"Не допущено, avg = {avg}");
        break;
    case > 4:
        Console.WriteLine($"Допущено, avg = {avg}");
        break;
}
