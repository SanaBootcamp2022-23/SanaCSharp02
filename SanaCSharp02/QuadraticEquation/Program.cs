using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int a, b, c;
double discrim, x1, x2;

Console.WriteLine("Введіть числа для ров'язання квадратного рівняння:");

Console.Write("a = ");
a = int.Parse(Console.ReadLine());

while (a == 0)
{
    Console.WriteLine("Значення {a} не може дорівнювати 0! Введіть інше значення:");
    Console.Write("a = ");
    a = int.Parse(Console.ReadLine());
}

Console.Write("b = ");
b = int.Parse(Console.ReadLine());

Console.Write("c = ");
c = int.Parse(Console.ReadLine());

discrim = Math.Pow(b, 2) - (4 * a * c);

Console.WriteLine($"\nD = {discrim}");

if (discrim < 0)
{
    Console.WriteLine("Ров'зяків рівняння немає.");
}
else if (discrim == 0)
{
    x1 = x2 = (-b + Math.Sqrt(discrim)) / (2 * a);
    Console.WriteLine($"x = {x1}");
}
else
{
    x1 = (-b - Math.Sqrt(discrim)) / (2 * a);
    x2 = (-b + Math.Sqrt(discrim)) / (2 * a);
    Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
}