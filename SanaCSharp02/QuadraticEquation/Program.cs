double a, b, c, D, x1, x2;

Console.Write("Введіть число a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть число b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Введіть число c: ");
c = double.Parse(Console.ReadLine());

D = Math.Pow(b, 2) - 4 * a * c;
if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"\nx1 = {x1}\nx2 = {x2}");
}
else if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"\nx1 = {x1}");
}
else
{
    Console.WriteLine("\nКоренів немає!");
}