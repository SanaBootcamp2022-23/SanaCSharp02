while (true)
{
    double a, b, c;

    Console.Write("Enter a -> ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    Console.Write("Enter b -> ");
    if (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }
    Console.Write("Enter c -> ");
    if (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Incorrect value");
        continue;
    }

    double discriminant = b * b - 4 * a * c;
    Console.WriteLine("discriminant = " + discriminant);

    if (discriminant > 0)
    {
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine("x1 = " + x1);
        Console.WriteLine("x2 = " + x2);
    }
    else if (discriminant == 0)
    {
        double x1 = -b / (2 * a);
        Console.WriteLine("x1 = " + x1);
    }
    else
    {
        Console.WriteLine("Discriminant less than zero");
    }
    Console.WriteLine();
}