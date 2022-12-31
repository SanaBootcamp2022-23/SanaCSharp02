// See https://aka.ms/new-console-template for more information

using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int a1, a2, a3, a4, a5;
double result;

Console.WriteLine("Привіт! Для того, щоб " +
    "визначити чи допущений студент до екзамену - введіть його 5 оцінок.");

Console.Write("оцінка \"1\": ");
a1 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("оцінка \"2\": ");
a2 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("оцінка \"3\": ");
a3 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("оцінка \"4\": ");
a4 = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("оцінка \"5\": ");
a5 = int.Parse(Console.ReadLine());
Console.WriteLine("");

result = (a1 + a2 + a3 + a4 + a5) / 5;

if (result >= 4)
{
    Console.WriteLine("Студента допущено до екзамену!");
}
else
{
    Console.WriteLine("Студента недопущено до екзамену!");
}