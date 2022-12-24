using System.Threading.Tasks;
using static System.Math;
Console.Write("Введіть n:");
int n = int.Parse(Console.ReadLine());
double a = 0;
double b = 0;
double c = 0;
double fct = 1;
int i = 1;
while(i<= n)
{
    a += Pow(-1.0, n) / (2.0 * n + 1);
    b += (1 + 1.0 / Pow(n, 2));
    fct *= i;
    c += fct;
    i++;
}

Console.WriteLine($"a= {a}\nb= {b}\nc= {c}");