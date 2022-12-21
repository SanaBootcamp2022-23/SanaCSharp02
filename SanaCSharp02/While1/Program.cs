using System.Text;
Console.OutputEncoding = UTF8Encoding.UTF8; //Для коректного відображення літери "і"

int n, factorial;
double a = 0, b = 0, c = 0;

do
{
    Console.Write($"Введіть n: ");
    if (int.TryParse(Console.ReadLine(), out n) && n >= 1) break;
    else
    {
        Console.Write("Введіть коректне значення n: ");
    }
} while (int.TryParse(Console.ReadLine(), out n) && !(n >= 1));

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1.0 / (i * i);
    factorial = 1;
    for (int j = 1; j <= i; j++)
        factorial *= j;
    c += factorial;
}
Console.WriteLine("Результат: ");
Console.WriteLine($"a = {Math.Round(a, 3)}\nb = {Math.Round(b, 3)}\nc = {Math.Round(c, 3)}");