// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int total = 5;
int average = 0;

Console.Write("Введіть оцінки: ");


for (int i = 1; i < total; i++)
{
    total += int.Parse(Console.ReadLine());
}

average = total / 5;

if (average >= 4)
{
    Console.WriteLine("Студента допущено до екзамену.");
}
else
{
    Console.WriteLine("Студента не допущено до екзамену.");
}