using System;

double a, b, c, x, x1, x2, D;

Console.WriteLine("Enter number a: ");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number b: ");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number c: ");
c = Convert.ToDouble(Console.ReadLine());
D = Math.Pow(b, 2) - 4 * a * c;
if (D < 0)
    {
    Console.WriteLine("Discriminant < 0, that`s mean, equation have no colutions");
    }
else if (a > 0)
    {
        if (D == 0)
        { 
            x = -b / (2 * a);
            Console.WriteLine($"X = {x}");
        }
        else if (D > 0)
        {
            x1 = (- b + Math.Sqrt(D) ) / (2 * a);
            x2 = (- b - Math.Sqrt(D) ) / (2 * a);
            Console.WriteLine($"X1 = {x1}\n");
            Console.WriteLine($"X2 = {x2}\n");


        }
    }
        else
        {
            Console.WriteLine("Without any solutions");
        }