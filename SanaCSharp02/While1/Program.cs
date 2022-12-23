// See https://aka.ms/new-console-template for more information

double resultA = 0, resultB = 0, resultC = 1;

Console.WriteLine("Input natural value:");
int inputNatNum = int.Parse(Console.ReadLine());

for(int i = 1; i <= inputNatNum; i++)
{
    resultA += Math.Pow(-1, i) / (2 * i + 1);
    resultB += 1 + 1 / Math.Pow(i, 2);
    resultC *= i;
}

Console.WriteLine($"a = {resultA}, b = {resultB}, c = {resultC}");