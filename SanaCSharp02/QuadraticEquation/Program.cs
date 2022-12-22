﻿// See https://aka.ms/new-console-template for more information
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("a = ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        var c = double.Parse(Console.ReadLine());
        double x1, x2;

        var discr = Math.Pow(b, 2) - 4 * a * c;
        if (discr < 0)
        {
            Console.WriteLine("Quadratic Equation has no roots");
        }
        else
        {
            if (discr == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discr)) / (2 * a);
                x2 = (-b - Math.Sqrt(discr)) / (2 * a);
            }
           
            Console.WriteLine($"x1 = {x1}; x2 = {x2}");
        }

        Console.WriteLine("Press any button...");
        Console.ReadKey(true);
    }
}