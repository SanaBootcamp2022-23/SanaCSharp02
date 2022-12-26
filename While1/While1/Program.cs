// See https://aka.ms/new-console-template for more information
int n;
double resultA = 0;
Console.WriteLine("n = ");
n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
    resultA += (Math.Pow(-1, n) / (2 * n) + 1);
Console.WriteLine(resultA);
double resultB = 0;
for (int i = 0; i <= n; i++)
    resultB += (1 + 1.0 / Math.Pow(n, 2));
Console.WriteLine(resultB);
double resultC = 1;
for (int i = 1; i <= n; i++)
    resultC *= i;
Console.WriteLine(resultC);
