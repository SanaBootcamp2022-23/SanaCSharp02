using System.Text;
double a, b, c, D, x, x1, x2;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть коефіцієнти квадратного рівняння:");
Console.Write("a = "); a = double.Parse(Console.ReadLine());
Console.Write("b = "); b = double.Parse(Console.ReadLine());
Console.Write("c = "); c = double.Parse(Console.ReadLine());

D = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"\nD = {D}");

x1 = (-b + Math.Sqrt(D) / 2 * a);
x2 = (-b - Math.Sqrt(D) / 2 * a);
x = -b / (2 * a);

if (D > 0)
    Console.WriteLine($"Рівняння має 2 корені: x1 = {x1}, x2 = {x2}");
else if (D == 0)
    Console.WriteLine($"Рівняння має 1 корінь: x = {x}");
else
    Console.WriteLine("Рівняння немає коренів");
