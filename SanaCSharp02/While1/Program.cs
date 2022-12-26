double n;
Console.Write("Введіть n:");
n = double.Parse(Console.ReadLine());

double a = 0;
double b = 0;
double c = 1;

while (n > 0)
{
    a += Math.Pow(-1, n) / (2 * n + 1);
    b += 1 + (1 / (n * n));
    c *= n;

    n--;
}
Console.WriteLine("Результат першого прикладу = {0}", a);
Console.WriteLine("Результат другого прикладу = {0}", b);
Console.WriteLine("Результат третього прикладу = {0}", c);
