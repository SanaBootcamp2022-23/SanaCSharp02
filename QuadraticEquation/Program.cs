using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
Console.Write("c = ");
int c = int.Parse(Console.ReadLine());
double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
if (D > 0)
    Console.WriteLine($"Два кореня\n" +
        $"x1 = {(-b + D) / (2 * a)}\n" +
        $"x2 = {(-b - D) / (2 * a)}");
else if (D == 0) Console.WriteLine($"Один корінь\nx = {-b / (2 * a)}");
else Console.WriteLine("Коренів немає D<0");