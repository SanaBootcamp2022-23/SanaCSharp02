
Console.Write("a: ");
double a = Convert.ToInt64(Console.ReadLine());
Console.Write("b: ");
double b = Convert.ToInt64(Console.ReadLine());
Console.Write("c: ");
double c = Convert.ToInt64(Console.ReadLine());
double D = Math.Pow(b,2) - 4*a*c;
Console.WriteLine("D = {0}", D);
if (D > 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
}
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine("x0 = {0}", x);
}
else if (D < 0)
{
    Console.WriteLine("D is not correct but D = {0}", D);
}