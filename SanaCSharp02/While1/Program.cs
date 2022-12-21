using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("Введіть число n");

int n;
n = int.Parse(Console.ReadLine());

double 
    a = 0,
    b = 0;
int factor = 1;

for(int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2.0 * i + 1.0);
    b += 1.0 + (1.0 / Math.Pow(i, 2));
}
for (int j = 2; j <= n; j++)
    factor *= j;

Console.WriteLine($"Відповіді на рівняння:\na = {a}\nb = {b}\nc = {factor}");