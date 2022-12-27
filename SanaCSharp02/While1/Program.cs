using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int n;
double a = 0, b = 0, c = 0, factorial = 1;

Console.Write("Введіть n(має бути натуральним) = ");
n = int.Parse(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        a += Math.Pow(-1.0, i) / (2.0 * i + 1);
        b += 1 + 1.0 / Math.Pow(i, 2);
        factorial *= i;
        c += factorial;
    }
    Console.WriteLine($"a = {a};\nb = {b};\nc = {c}");
}
else
{
   Console.WriteLine("Помилка! Число не є натуральним!");
}
    

