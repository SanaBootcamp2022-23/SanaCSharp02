using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть натуральне число n: ");
int n = int.Parse(Console.ReadLine());
if(n <= 0)
{
    Console.Write("Ви ввели не натуральне число!");
    return;
}
double a = 0, b = 0, c = 0, factorial = 1;
for(int i=1; i<=n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / Math.Pow(i, 2);
    factorial *= i; 
    c += factorial;
}
Console.Write($"a = {a}\nb = {b}\nc = {c}");