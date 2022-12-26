using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double est1, est2, est3, est4, est5, res;

Console.Write("Введіть 1 оцінку:");
est1 = double.Parse(Console.ReadLine());

Console.Write("Введіть 2 оцінку:");
est2 = double.Parse(Console.ReadLine());

Console.Write("Введіть 3 оцінку:");
est3 = double.Parse(Console.ReadLine());

Console.Write("Введіть 4 оцінку:");
est4 = double.Parse(Console.ReadLine());

Console.Write("Введіть 5 оцінку:");
est5 = double.Parse(Console.ReadLine());

if (est1 <= 5 && est1 >= 0 && est2 <= 5 && est2 >= 0 && est3 <= 5 && est3 >= 0 && est4 <= 5 && est4 >= 0 && est5 <= 5 && est5 >= 0)
{
    res = (est1 + est2 + est3 + est4 + est5) / 5.0;

    Console.WriteLine("-----результат-----");

    if (res >= 4)
    {
        Console.Write("Студент допущений до екзамену");
    }
    else
    {
        Console.Write("Студент не допущений до екзамену");
    }
}
else
{
    Console.Write("Введені невірні дані");
}
