using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
double a=0, b=0, c=0, n;
int  i = 1,fact=1;
Console.WriteLine("Введіть n:");
n = int.Parse(Console.ReadLine());
while (n >= i)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / (Math.Pow(i, 2));
    fact *= i;
    c += fact;
    
    i++;
    
}
Console.WriteLine("a={0}, b={1}, c={2}",a,b,c); 
