using System.Text;
Console.OutputEncoding = Encoding.UTF8;
float a, b, c, d,x1, x2, x;

Console.Write("Введіть число a:");
a=float.Parse(Console.ReadLine());
Console.Write("Введіть число b:");
b = float.Parse(Console.ReadLine());
Console.Write("Введіть число c:");
c = float.Parse(Console.ReadLine());
d = (float)(Math.Pow(b, 2) - 4 * a * c);
Console.Write($"D={d}\n");

if (d>0)
{
    x1=(-b+ (float)Math.Sqrt(d))/(2*a);
    x2 = (-b - (float)Math.Sqrt(d)) / (2 * a);
    Console.Write($"x1={x1}\nx2={x2}");
}
if (d == 0)
{
    x1=(-b)/(2*a);
    Console.Write("x1="+x1);
}
if(d < 0)
   Console.Write("Коренів немає");
