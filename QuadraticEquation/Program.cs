using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int a, b, c;

Console.WriteLine("Введіть а (Не має дорівнювати 0): ");
    a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть b: ");
    b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть с: ");
    c = int.Parse(Console.ReadLine());

if (a != 0)
{
    double D = b * b - 4 * a * c;
    Console.WriteLine($"Дискримінант = {D}");

    if (D > 0)
    {
        double x1 = (-b + Math.Sqrt(D)) / (2 * a);
        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine($"Два розв'язки: x1 = {x1}, x2 = {x2}");
    }
    else if (D == 0)
    {
        double x = -b / 2 * a;
        Console.WriteLine($"Розв'язок один x = {x}");
    }
    else
    {
        Console.WriteLine("Розв'язків немає");
    }
}
else
{
    Console.WriteLine("ERROR!!! а = 0!");
}