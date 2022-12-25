using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
int number;
double a=0, b=0, c=0;
Console.Write("Введіть число: ");
number = int.Parse(Console.ReadLine());
int n = 1;
int factorial = 1;
while (n<=number)
{
    a += Math.Pow(-1, n)/(2*n+1);
    b += (1 + 1 / Math.Pow(n, 2));
    factorial *= n;
    c += factorial;
    n++;
}
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");
