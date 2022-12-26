using System;

double c, K;
double a = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter mark: ");
    c = Convert.ToDouble(Console.ReadLine());
    a = a + c;
}
Console.WriteLine($"sum of marks : {a}\n");

K = a / 5;
if (K < 4)
{
    Console.WriteLine("Not allowed for examination");
}
else
{
    Console.WriteLine("Allowed for examination");
}