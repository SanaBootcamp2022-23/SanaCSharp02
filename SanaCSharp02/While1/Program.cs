double a=0;
double b=0;
double c = 0;
double factorial = 1;

int n;
Console.WriteLine("enter n");
n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / Math.Pow(i, 2);
    factorial = factorial * i;
    c += factorial; 
}

Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"c={c}");