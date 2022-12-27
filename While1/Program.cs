using System;
double n=0;
int step=1;
double a = 0, b = 0, c = 0, fact = 1;



Console.Write("Input number n:");
n = double.Parse(Console.ReadLine());
while (step<=n)
{
    a = a + Math.Pow(-1,n)/((2*n)+1);
    b = b + ((1) + (1)/ Math.Pow(n, 2));

    fact= fact*step;
    c += fact; 

    step++;
    
}
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"c={c}");