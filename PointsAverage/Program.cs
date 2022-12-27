using System;

double m1, m2, m3, m4, m5, av;

Console.WriteLine("Enter 5 marks (each number on a separate line)");
m1 = Convert.ToDouble(Console.ReadLine());
m2 = Convert.ToDouble(Console.ReadLine());
m3 = Convert.ToDouble(Console.ReadLine());
m4 = Convert.ToDouble(Console.ReadLine());
m5 = Convert.ToDouble(Console.ReadLine());

av = (m1 + m2 + m3 + m4 + m5) / 5;

if (av >= 4)
{
    Console.WriteLine("Admitted to the exam.");
}
else
{
    Console.WriteLine("Not admitted to the exam.");
}