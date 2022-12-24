
double a, b=0,s;
Console.WriteLine("Введiть оцінки студента");
for (int i = 0; i < 5; i++)
{
    a = Convert.ToDouble(Console.ReadLine());
    b += a;
}
s = b / 5;
if (s >= 4)
{
    Console.WriteLine("Студент допущений до екзамену");
    Console.WriteLine("Поточна середня оцінка " + s);
}
else
{
    Console.WriteLine("Студент не допущений до екзамену");
    Console.WriteLine("Поточна середня оцінка " + s);
}
    