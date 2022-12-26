// See https://aka.ms/new-console-template for more information
Console.WriteLine("Середня оцiнка студента");

double sum = 0;
Console.WriteLine("Введiть 5 оцiнок студента: ");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i + 1 + " оцiнка");
    sum += double.Parse(Console.ReadLine());
}

if (sum/5 >= 4)
{
    Console.WriteLine("Середня оцiнка студента = " + sum / 5);
    Console.WriteLine("Допуск до екзамену отримано");
}
else
{
    Console.WriteLine("Середня оцiнка студента = " + sum / 5);
    Console.WriteLine("Допуску до екзамену немає");
}