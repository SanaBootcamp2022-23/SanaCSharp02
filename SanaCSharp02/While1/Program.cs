// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n;
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
double a, b, c;
double factorial = 1;
Console.Write("a = ");
a = int.Parse(Console.ReadLine());
Console.Write("b = ");
b = int.Parse(Console.ReadLine());
Console.Write("c = ");
c = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / Math.Pow(i, 2);
    factorial*= i;
    c += 1 / factorial;
    Console.WriteLine($"а={a}");
    Console.WriteLine($"b={b}");
    Console.WriteLine($"c={c}");
}
