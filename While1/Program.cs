double n;
double resultA = 0;
double resultB = 0;
double resultC = 0;
double factor = 1;

Console.Write("Input number n = ");
n = double.Parse(Console.ReadLine());
for (double i = 1; i <= n; i++)
{
    resultC += i;
}
Console.WriteLine($"c = {resultC}");


for (double i = 1; i <= n; i++)
{
    double calculateB = 1 + (1 / Math.Pow(i, 2));
    resultB += calculateB;
}
Console.WriteLine($"b = {resultB}");
for (double i = 1; i <= n; i++)
{
    double calculateA = Math.Pow(-1,i)/((2 * i) + 1);
    resultA += calculateA;
}
Console.WriteLine($"a = {resultA}");



//(i*2)+1
//factor *= i;//