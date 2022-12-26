// See https://aka.ms/new-console-template for more information
Console.WriteLine("Програма --- Квадратнi рiвняння ---'");
Console.WriteLine("Введiть числа a, b, c");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

double d = Math.Pow(b, 2) - 4 * a * c;

if (d == 0)
{
    Console.WriteLine("Рiвняння має один корiнь:");
    Console.WriteLine("X =" + ((-b) / (2 * a)));
}
else if (d > 0)
{
    Console.WriteLine("Рiвняння має два коренi:");
    Console.WriteLine("X1 = " + ((-b + Math.Sqrt(d)) / (2 * a)));
    Console.WriteLine("X2 = " + ((-b - Math.Sqrt(d)) / (2 * a)));
}
else if (d < 0)
{
    Console.WriteLine("Рiвняння НЕ має коренiв:");
}