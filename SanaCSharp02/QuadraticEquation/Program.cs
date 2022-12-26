using static System.Math;
int a, b, c;
Console.Write("a: "); a = int.Parse(Console.ReadLine());
Console.Write("b: "); b = int.Parse(Console.ReadLine());
Console.Write("c: "); c = int.Parse(Console.ReadLine());
double D,dsqrt,x1,x2;
D = b * b - 4 * a * c;
if(a== 0) Console.WriteLine("a не може дорівнювати 0");
if (D > 0)
{
    dsqrt = Pow(D,2);
    x1 = (-b + dsqrt) / (2 * a);
    x2 = (-b - dsqrt) / (2 * a);
    Console.WriteLine($"Result of x1 = {x1}, x2 = {x2}");
}
if(D==0)
{
    dsqrt = Pow(D, 2);
    x1 = -b / (2 * a);
    Console.WriteLine($"Result of x = {x1}");
}
if(D<0) Console.WriteLine("D<0");