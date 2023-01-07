// ax^2+bx+c=0

using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int a, b, c;
double x1, x2, D;

Console.WriteLine("Привіт! Для вирішення квадратного" +
    " рівняння вам необхідно ввести наступні параметри змінні:");

Console.Write("значення \"a\", де а ≠ 0: ");
a = int.Parse(Console.ReadLine());

while (a == 0)
{
    Console.Write("Помилка! Не дотримано умову \"а ≠ 0\". " +
        "Введіть повторно значення \"a\": ");
    a = int.Parse(Console.ReadLine());
}
Console.WriteLine("");

Console.Write("значення \"b\": ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("значення \"c\": ");
c = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Знаходимо дискримінант:");
D = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"Дискримінант = {D}");
Console.WriteLine("");

if (D < 0)
{
    Console.WriteLine("Так як \"D < 0\" - рівняння немає дійсних коренів");
}
else if (D == 0)
{
    x1 = (-b) / (2 * a);
    Console.WriteLine($"Так як \"D = 0\" - рівняння має два рівних корені: {x1}");
}
else // (D > 0)
{
    x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
    x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"Так як \"D > 0\" - рівняння має два різних корені: {x1} та {x2}");
}

