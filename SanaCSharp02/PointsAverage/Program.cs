double a, b = 0, m;
Console.WriteLine("Введiть оцінки студента");
for (int i = 0; i < 5; i++)
{
    a = Convert.ToDouble(Console.ReadLine());
    b += a;
}
m = b / 5;
if (m >= 4)
{
    Console.WriteLine("Студент допущений до екзамену");
    Console.WriteLine("Середня оцінка " + m);
}
else
{
    Console.WriteLine("Студент не допущений до екзамену");
    Console.WriteLine("Середня оцінка " + m);
}