using System.Text;


Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
double a;
double b;
double c;
double x1;
double x2;
double discriminant;
Console.Write("a=");
a = double.Parse(Console.ReadLine());
Console.Write("b=");
b = double.Parse(Console.ReadLine());
Console.Write("c=");
c = double.Parse(Console.ReadLine());

discriminant = Math.Pow(b, 2) - 4 * a * c;

if (discriminant > 0)
{
    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
    x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
    Console.WriteLine($"Дискримінант:{discriminant}");
    Console.WriteLine($"Розв'язання:{x1},{x2}"); ;
}
else if (discriminant == 0)
{
    Console.WriteLine("Тільки 1 розв'язання");
    x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
    Console.WriteLine($"Дискримінант:{discriminant}");
    Console.WriteLine($"Розв'язання:{x1}");

}
else if (discriminant < 0)
{
    Console.WriteLine("Немає розв'язання(");
    Console.WriteLine($"Дискримінант:{discriminant}");

}
   