Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("c: ");
double c = Convert.ToDouble(Console.ReadLine());
double d = b * b - 4 * a * c;
if(d == 0)
{
    double x = (-b) / (2 * a);
    Console.WriteLine("x = " + x);
}
if(d > 0)
{
    double x1 = (Math.Sqrt(d) - b) / (2 * a);
    double x2 = (-Math.Sqrt(d) - b) / (2 * a);
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
if(d < 0)
{
    Console.WriteLine("The equation has no roots");
}