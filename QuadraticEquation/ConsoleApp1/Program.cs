using System;

class Program
{
    public static void Main(string[] args)
    {
        double a, b, c, D, x1, x2;
        Console.WriteLine("Enter the value of a");
        Console.Write("-> ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        Console.Write("-> ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of c");
        Console.Write("-> ");
        c = double.Parse(Console.ReadLine());

        D = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine("D ->" + D);

        if (D < 0)
            Console.WriteLine("Roots do not exist");
        else if (D == 0)
            Console.WriteLine("x -> " + -b / 2 * a);
        else
        {
            x1 = (-b + Math.Sqrt(D)) / 2 * a;
            x2 = (-b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine($"x1 -> {x1} \nx2 -> {x2}");
        }

    }
}