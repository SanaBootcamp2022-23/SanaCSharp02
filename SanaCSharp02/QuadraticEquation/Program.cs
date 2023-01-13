double dis, a, b, c, x1, x2;

Console.WriteLine("Quadratic equation");
do
{
    Console.Write("Input value for a, while a != 0\na = ");
} while (!double.TryParse(Console.ReadLine(), out a) || a == 0);

do
{
    Console.Write("Input value for b\nb = ");
} while (!double.TryParse(Console.ReadLine(), out b));

do
{
    Console.Write("Input value for c\nc = ");
} while (!double.TryParse(Console.ReadLine(), out c));

dis = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"Discriminant = {dis}");

if (dis < 0)
{
    Console.WriteLine("Discriminant < 0 the equation has no real roots");
}
else if (dis == 0)
{
    x1 = (-b) / (2 * a);
    Console.Write($"The equation has two same roots X1,X2 = {x1}");
}
else 
{
    x1 = ((-b) + Math.Sqrt(dis)) / (2 * a);
    x2 = ((-b) - Math.Sqrt(dis)) / (2 * a);
    Console.Write($"The equation has two roots X1 = {x1}, X2 = {x2}");
}
