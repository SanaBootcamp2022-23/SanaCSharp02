// See https://aka.ms/new-console-template for more information
Console.WriteLine("While1");
Console.Write("Введіть натуральне число n: ");

int n = int.Parse(Console.ReadLine());

double a = 0;
double b = 0;
double c = 0;
int factorial = 1;

int i = 1;
while (i <= n)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + (1 / Math.Pow(i, 2));
    factorial *= i;
    c += factorial;
    i++;
}

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.ReadLine();
