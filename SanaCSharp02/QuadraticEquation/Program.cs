using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть число а: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введіть число b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введіть число c: ");
double c = double.Parse(Console.ReadLine());
double discriminant = Math.Pow(b, 2) - 4 * a * c;
if (discriminant < 0)
    Console.WriteLine($"Дискримінант дорівнює {discriminant}\nКорнів немає");
else if(discriminant == 0)
{
    double x = (-1.0*b)/(2*a);
    Console.WriteLine($"Дискримінант дорівнює {discriminant}\nІснує один корінь: {x}");
}
else
{
    double x1 = (-1 * b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-1 * b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine($"Дискримінант дорівнює {discriminant}\nПерший корінь: {x1}\nДругий корінь: {x2}");
}
