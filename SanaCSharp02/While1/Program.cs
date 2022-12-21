// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введіть натуральне число n = ");
int n;
double a = 0, b = 0, c = 0, fact = 1;
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
   a += (Math.Pow(-1, i) / (2 * i + 1));
    b += (1 + (1 / Math.Pow(n, 2)));
    fact *= i;
    c += fact;
}
Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);