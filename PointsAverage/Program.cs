double a, b, c, d, e;

Console.Write("Лабораторна робота :");
a = double.Parse(Console.ReadLine());

Console.Write("РГР:");
b = double.Parse(Console.ReadLine());

Console.Write("Тест1:");
c = double.Parse(Console.ReadLine());

Console.Write("Тест2:");
d = double.Parse(Console.ReadLine());

Console.Write("МКР:");
e = double.Parse(Console.ReadLine());

double avrg = (a + b + c + d + e) / 5;

if (avrg >= 4)
{
    Console.WriteLine("Вас допущено до екзамену!");
}
else
{
    Console.WriteLine("Вас НЕ допущено до екзамену!");

}

