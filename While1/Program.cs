using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int n, factorial = 1;
double a = 0, b = 0, c = 1;

Console.WriteLine("Введіть натуральне число n = ");
n = int.Parse(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        a += Math.Pow(-1.0, i) / (2.0 * i + 1);
        b += (1 + 1.0 / (i * i));
        factorial *= i;
        c += factorial;
    }


    Console.WriteLine($"a = {a}, b = {b}, c = {c}");
}
else
    Console.WriteLine("ERROR!!! Введено не натуральне число!");