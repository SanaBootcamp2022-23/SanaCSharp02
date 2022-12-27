using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int a, b, c;

Console.WriteLine("Введіть а: ");
a = int.Parse(Console.ReadLine());
if (a != 0)
{
    Console.WriteLine("Введіть b: ");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть с: ");
    c = int.Parse(Console.ReadLine());

    double d = Math.Pow(b, 2) - 4 * a * c;
    Console.WriteLine($"D = {d}");

    if (d > 0)
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"x1 = {x1}; x2 = {x2}");
    }
    else if (d == 0)
    {
        double x = -b / 2 * a;
        Console.WriteLine($"x = {x}");
    }
    else
    {
        Console.WriteLine("Рівняння немає дійсних коренів");
    }
}
else
{
    Console.WriteLine("Помилка! a = 0");
}

