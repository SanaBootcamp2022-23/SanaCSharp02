using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double point1, point2, point3, point4, point5, avarege;
Console.WriteLine("Введіть 5 оцінок студента:");
point1 = double.Parse(Console.ReadLine());
point2 = double.Parse(Console.ReadLine());
point3 = double.Parse(Console.ReadLine());
point4 = double.Parse(Console.ReadLine());
point5 = double.Parse(Console.ReadLine());

avarege = (point1 + point2 + point3 + point4 + point5) / 5.0;
Console.WriteLine($"Серднє арифметичне = {avarege}");
if (avarege > 4.0)
    Console.WriteLine("Студент допущений до екзамену");
else
    Console.WriteLine("Студент не допущений до екзамену");