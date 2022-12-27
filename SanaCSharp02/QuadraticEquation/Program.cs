// See https://aka.ms/new-console-template for more information

double a, b, c, Dis;

Console.Write("Enter a : "); a = double.Parse(Console.ReadLine());
Console.Write("Enter b : "); b = double.Parse(Console.ReadLine());
Console.Write("Enter c : "); c = double.Parse(Console.ReadLine());
Dis = Math.Pow(b, 2) - 4 * a * c;

if (a == 0)
{
    double x;
    x = -(c) / b;
    Console.WriteLine($"\nIs not a quadratic, but a linear equation of the form bx+c=0, in which x = {x}");
}
else {
    if (Dis > 0)
    {
        double x1, x2;
        x1 = ((b * (-1)) + Math.Sqrt(Dis)) / (2 * a);
        x2 = ((b * (-1)) - Math.Sqrt(Dis)) / (2 * a);
        Console.WriteLine("quadratic equation has 2 solutions");
        Console.WriteLine($"\nx1 = {Math.Round(x1, 3)} x2 = {Math.Round(x2,3)}");
    }
    else if (Dis == 0)
    {
        double x;
        x = (b / (2 * a)) * (-1);
        Console.WriteLine("quadratic equation has 1 solutions");
        Console.WriteLine($"\nx = {x}");
    }
    else
    {
        Console.WriteLine("\nquadratic equation has no solutions");
    }
}

