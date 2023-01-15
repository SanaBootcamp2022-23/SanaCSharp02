using System.Text;
Console.OutputEncoding = Encoding.UTF8;
double mark, k = 0, s;

Console.WriteLine("Введiть оцінки студента");
for (int i = 0; i < 5; i++)
{
    mark = Convert.ToDouble(Console.ReadLine());
    k += mark;
}
s = k / 5;
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