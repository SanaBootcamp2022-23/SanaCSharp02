double n ;
double resultA = 0;
double resultB = 0;
double resultC = 0;
double factorial = 1;


Console.Write("Input number n = ");
n = double.Parse(Console.ReadLine());

for (double i = 1; i <= n; i++)
{
    factorial *= i;
    resultC += factorial;

    double calculateB = 1 + (1 / Math.Pow(i, 2));
    resultB += calculateB;

    double calculateA = Math.Pow(-1,i)/((2 * i) + 1);
    resultA += calculateA;
}
Console.WriteLine($"a = {resultA}");
Console.WriteLine($"b = {resultB}");
Console.WriteLine($"c = {resultC}");
