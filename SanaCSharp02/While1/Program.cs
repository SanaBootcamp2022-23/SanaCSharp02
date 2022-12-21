int n;
do
    Console.WriteLine($"Input n = ");
while (!int.TryParse(Console.ReadLine(), out n));
double result=0;
for (int i = 1; i <= n; i++)
{
    result += Math.Pow(-1,i+1)*(1.0 / (i*2 + 1));
}
Console.WriteLine($"a = {result}");
result = 0;
for (int i = 1;i<=n;i++)
{
    result += 1 + 1 / Math.Pow(i, 2);
}
Console.WriteLine($"b = {result}");
result = 0;
int faktorial=1;
for (int i = 1; i <= n; i++)
{
    faktorial*= i;
    result += faktorial;
}
Console.WriteLine($"c = {result}");
