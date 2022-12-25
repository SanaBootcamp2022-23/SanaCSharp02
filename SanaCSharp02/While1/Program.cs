using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

double a = 0, b = 0, c = 0, factorial;
int n, k = 1;
Console.WriteLine("Введіть число n");
n = int.Parse(Console.ReadLine());

while (k <= n)
{
    a += Math.Pow(-1, k) / (2 * k + 1);
    b += (1 + (1 / Math.Pow(k, 2)));
    factorial = 1;
    for(int i = 1; i <= k; i++)
    {
        factorial *= i;
    }
    c += factorial;
    k++;
}

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");