Console.WriteLine("Input number n");
int n = int.Parse(Console.ReadLine());
int i = 1;

double a = 0;
double b = 0;
double c = 0;
while (i <= n)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    
    b += 1 + (1 / Math.Pow(i, 2));

    double fact = 1;
    for(int j = 1; j <= i; j++)
    {
        fact *= j;
    }
    c += fact;

    i++;
}

Console.WriteLine($"Result of calculation of expression a: {a}");
Console.WriteLine($"Result of calculation of expression b: {b}");
Console.WriteLine($"Result of calculation of expression c: {c}");
