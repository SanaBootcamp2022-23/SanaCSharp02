// See https://aka.ms/new-console-template for more information
//SanaCShapr02
//Bohdan Serdeniuk

using System.Numerics;

//initialization of variables
Console.WriteLine("enter a natural number n");
uint n = uint.Parse(Console.ReadLine());
uint factorial = 1;
double a = 0, b = 0, c = 0;

//calculation of the result and output of the result

    uint i = 1;
    while (i <= n)
    {
        a = a + (Math.Pow(-1.0, i) / (2.0 * i + 1));
        b = b + (1 + (1.0 / Math.Pow(i, 2)));
        factorial = factorial * i;
        c = c + factorial;

        i++;
    }
Console.WriteLine($"\nresults:\na = {a},\nb = {b},\nc = {c}");