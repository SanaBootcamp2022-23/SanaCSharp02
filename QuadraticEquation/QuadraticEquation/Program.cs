// See https://aka.ms/new-console-template for more information
double a, b, c, x1, x2, d;
Console.Write("a=");
a = float.Parse(Console.ReadLine());
Console.Write("b=");
b = float.Parse(Console.ReadLine());
Console.Write("c=");
c = float.Parse(Console.ReadLine());

d = b * b - 4 * a * c;
Console.WriteLine(d);

if (d > 0)
{
    x1 = ((-b) + Math.Pow(d, 2)) / (2*a);
    x2 = ((-b) - Math.Pow(d, 2)) / (2 * a);
    Console.WriteLine(x1);
    Console.WriteLine(x2);
}
if (d == 0)
{
    x1 = -(b / (2 * a));
    Console.WriteLine("x1=x2 = ", x1);

}
if(d < 0)
{
    Console.WriteLine("Корнів не існує");
}


