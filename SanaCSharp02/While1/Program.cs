// See https://aka.ms/new-console-template for more information
int inputN;
double resultA = 0, resultB = 0, resultC = 0;
double factorial = 1;

Console.Write("N = ");
inputN = int.Parse(Console.ReadLine());

int i = 1;

while (i <= inputN)
{
    resultA += Math.Pow(-1.0, inputN) / (2.0 * inputN + 1);
    resultB += (1 + 1.0 / Math.Pow(inputN, 2));
    factorial *= i;
    resultC += factorial;
    i++;
}

Console.WriteLine($"a = {resultA}");
Console.WriteLine($"b = {resultB}");
Console.WriteLine($"c = {resultC}");