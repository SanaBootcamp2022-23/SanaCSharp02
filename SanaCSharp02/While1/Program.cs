int n, i;
double resultA = 0, resultB = 0, resultC = 0, factorial = 1;
Console.WriteLine("Enter n: ");
n = int.Parse(Console.ReadLine());
for(i = 1; i <= n; i++)
{
    resultA += Math.Pow(-1, i) / (2 * i + 1);
    resultB += 1 + 1 / Math.Pow(i, 2);
    factorial *= i;
}
resultC += factorial;
Console.WriteLine($"Result a: {resultA}");
Console.WriteLine($"Result b: {resultB}");
Console.WriteLine($"Result c: {resultC}");
