int N;
double resultA = 0;
double resultB = 0;
double resultC = 0;
double factorial = 1;
Console.Write("n = ");
N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    resultA += Math.Pow(-1.0, i) / (2 * i + 1);
    resultB += 1 + 1 / Math.Pow(i, 2);
    factorial *= i;
    resultC += factorial;
}
Console.WriteLine($"A = {resultA}");
Console.WriteLine($"B = {resultB}");
Console.WriteLine($"C = {resultC}");
