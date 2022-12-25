using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
double a, b, c, D, x, x1, x2;

double enternubmer(string name, out double nubmer)
{
    Console.Write($"Введiть число {name}: ");
    while (!double.TryParse(Console.ReadLine(), out nubmer))
    {
        Console.Write($"Невірно введенно число {name}, введіть ще раз число {name}: ");
    }
    return nubmer;
}
a = enternubmer("a", out a);
b = enternubmer("b", out b);
c = enternubmer("c", out c);
D = Math.Pow(b, 2) - 4 * a * c;
if (a == 0)
{
    x = -(c) / b;
    Console.Write($"Значення a = {a}, отже це не квадратне, а лінійне рівняння вигляду bx+c=0, в якому x = {x}");
}
else
{

    if (D < 0)
    {
        Console.Write($"Дискрімінант = {D}, отже рішень немає");
    }
    else if (D == 0)
    {
        x = -b / (2 * a);
        Console.Write($"Дискрімінант = {D}, отже рівняння має одне рішення:\n x = {x} ");
    }
    else
    {
        x1 = (-b + Math.Sqrt(D)) / (2 * a);
        x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.Write($"Дискрімінант = {D}, отже рівняння має одне два рішення:\n x1 = {x1}\n x2 = {x2}");
    }
}