using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, D;
            Console.WriteLine("Input a :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c :");
            c = Convert.ToDouble(Console.ReadLine());

            D = Math.Pow(b, 2.0) - (4 * a * c);
            x1 = (-b - Math.Sqrt(D)) / (2 * a);
            x2 = (-b + Math.Sqrt(D)) / (2 * a);

            if (D == 0)
            {
                Console.WriteLine("\nD = " + D);
                Console.WriteLine("Two equal roots :\nx1; x2 = " + x1);
            }
            if (D < 0)
            {
                Console.WriteLine("\nD = " + D);
                Console.WriteLine("There are no valid roots ");
            }
            if (D > 0) 
            {
                Console.WriteLine("Two different roots :");
                Console.WriteLine("\nD = " + D);
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }

    }
}