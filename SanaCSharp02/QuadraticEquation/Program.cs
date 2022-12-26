double a, b, c, d;

Console.Write("Введіть число а:");
a = double.Parse(Console.ReadLine());

Console.Write("Введіть число b:");
b = double.Parse(Console.ReadLine());

Console.Write("Введіть число c:");
c = double.Parse(Console.ReadLine());

d = b * b - 4 * a * c;

if (d < 0)
{
    Console.WriteLine("{0} < 0, тому дискримінант  коренів не має!", d);
}
else if (d > 0)
{
    double x1, x2;

    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);

    Console.WriteLine("Перший корень дискримінанту {0} = {1}", d, x1);
    Console.WriteLine("Другий корень дискримінанту {0} = {1}", d, x2);
}
else
{
    double x;

    x = (-b) / (2 * a);
    Console.WriteLine("Корень дискримінанту {0} = {1}", d, x);
}