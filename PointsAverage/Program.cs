using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
int count = 5;
double x, averagepoint, sum = 0;

double enternubmer(string name, int i, out double nubmer)
{
    Console.Write($"Введiть {i + 1} {name}: ");
    while (!double.TryParse(Console.ReadLine(), out nubmer) || !(nubmer >= 1 && nubmer <= 5))
    {
        Console.Write($"Невірно введенно {name}, введіть ще раз {name}: ");
    }
    return nubmer;
}
for (int i = 0; i < count; i++)
{

    x = enternubmer("оцінку", i, out x);
    sum = sum + x;
}

averagepoint = sum / count;
if (averagepoint >= 4)
    Console.Write($"Середня оцінка студента = {averagepoint}, студент допущений до екзамену");
else
    Console.Write($"Середня оцінка студента = {averagepoint}, студент не допущений до екзамену");