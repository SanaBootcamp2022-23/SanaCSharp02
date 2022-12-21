
int n;
double resultA = 0;

Console.Write("n = ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
    resultA += Math.Pow(-1, i) / (2 * i + 1);

Console.WriteLine($"a = {resultA}");

double resultB = 0;

for (int i = 1; i <= n; i++)
    resultB += 1 + (1 / Math.Pow(i, 2));

Console.WriteLine($"b = {resultB}");

double resultC = 0;
double factor = 1;

for (int i = 1; i <= n; i++)
{
    factor *= i;
    resultC += factor;
}

Console.WriteLine($"c = {resultC}");

