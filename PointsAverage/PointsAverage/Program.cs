// See https://aka.ms/new-console-template for more information
double a, b, c, d, e, grade;
Console.Write("Введіть оціку 1 ");
a = float.Parse(Console.ReadLine());
Console.Write("Введіть оцінку 2 ");
b = float.Parse(Console.ReadLine());
Console.Write("Введіть оцінку 3 ");
c = float.Parse(Console.ReadLine());
Console.Write("Введіть оцінку 4 ");
d = float.Parse(Console.ReadLine());
Console.Write("Введіть оцінку 5 ");
e = float.Parse(Console.ReadLine());

grade = (a + b + c + d + e) / 5;
if (grade >= 4)
{
    Console.Write("Допущений");
}
if(grade < 4)
{
    Console.Write("Не допущений");
}