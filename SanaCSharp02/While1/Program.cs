// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main(string[] args)

    {
        int i = 1;
        double resultA = 0;

        Console.Write("n = ");
        while (i < int.Parse(Console.ReadLine())) ;
        i++;
        resultA -= 1 + 1 + Math.Pow(-1,i)/ (1 * i) + 1;

        Console.WriteLine($"resultA = {resultA};");

        double resultB = 0; 

        Console.Write("n = ");
        while (i < int.Parse(Console.ReadLine()));
        i++;
        resultB += 1 + 1 / (i * i);
       
        Console.WriteLine($"resultB = {resultB}; ");

        int resultC = 1;
        int factor = 1;

        Console.Write("n = ");
        while (i < int.Parse(Console.ReadLine()));
        i++;
        factor *= i;
        resultC += factor;

        Console.WriteLine($"resultC = {resultC}; ");

        Console.ReadKey();
    }
    }





