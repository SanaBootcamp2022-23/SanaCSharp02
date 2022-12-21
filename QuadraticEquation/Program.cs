int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
if (D > 0)
{
    Console.WriteLine($"x1={(-b + D) / (2 * a)}");
    Console.WriteLine($"x2={(-b - D) / (2 * a)}");
}
else if (D == 0) Console.WriteLine($"x={-b / (2 * a)}");
else Console.WriteLine("D<0");