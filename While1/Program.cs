int n,factorial = 1, i = 1;
Console.WriteLine("Please, input n");
n = Convert.ToInt32(Console.ReadLine());

double a=0, b=0, c = 0;

while (i<=n)
{
    a += (Math.Pow(-1, i) / (2 * i + 1));
    b += (1 + 1 / Math.Pow(i,2));
    factorial *= i;
    c += factorial;
    i++;
}

Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");