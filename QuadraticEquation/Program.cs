// See https://aka.ms/new-console-template for more information
Console.WriteLine("Розв'язування квадратного рівняння");
Console.WriteLine("Введіть значення a, b та c:");

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());

double discriminant = b * b - 4 * a * c;
Console.WriteLine("Дискримінант: " + discriminant);
if (discriminant < 0)
{
    Console.WriteLine("Немає реальних коренів.");
}
else if (discriminant == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("Є один корінь: x = " + x);
}
else
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.WriteLine("Є два корені: x1 = " + x1 + ", x2 = " + x2);
}
Console.ReadLine();