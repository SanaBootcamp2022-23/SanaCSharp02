int n;
double resultA = 0;
double resultB = 0;
double resultC = 0;
double factor = 1;
Console.WriteLine("Веддiть число n:");
n = int.Parse(Console.ReadLine());

int i = 1;
while (i <= n)
{
    resultA += Math.Pow(-1.0, n) / (2.0 * n + 1);
    resultB += (1 + 1.0 / (n * n));
    factor *= i;
    resultC += factor;
    i++;
}

Console.WriteLine($"а={resultA}");
Console.WriteLine($"b={resultB}");
Console.WriteLine($"c={resultC}");