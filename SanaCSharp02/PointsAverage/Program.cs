// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введіть 5 оцінок студента:");
double point = 0;
point += double.Parse(Console.ReadLine());
point += double.Parse(Console.ReadLine());
point += double.Parse(Console.ReadLine());
point += double.Parse(Console.ReadLine());
point += double.Parse(Console.ReadLine());
double avgPoint = point / 5;
Console.WriteLine("Середній бал студента: " + avgPoint);
if (avgPoint >= 4)
{
    Console.WriteLine("Студент допущений до екзамену");
}
if (avgPoint < 4)
{
    Console.WriteLine("Студент не допущений до екзамену");
}

