double a, b, c;

double D, x1, x2;

Console.WriteLine("Please, input number a");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input number b");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input number c");
c = Convert.ToDouble(Console.ReadLine());

D = Math.Pow(b, 2) - 4 * a * c;
if(D==0)
{
    x1 = -b / (2.0 * a);
    Console.WriteLine($"D={D} x1 = x2 = {x1}");
}
else if (D>0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"D={D} x1 = {x1}\nx2 = {x2}");
}
else
{
    Console.WriteLine("There are no solutions");
}