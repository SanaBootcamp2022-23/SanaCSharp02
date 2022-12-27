Console.WriteLine("While1");
Console.Write("Enter natural number n: ");

int n;
n = Convert.ToInt32(Console.ReadLine());

double a = 0, b = 0, c = 0, factorial = 1;
int i = 1;
while (i <= n)
{
    a += (double)Math.Pow((-1), i) / (double)(2 * i + 1);
    b += 1 + 1 / (double)Math.Pow(i, 2);
    factorial *= i;
    c += factorial;
    i++;
}

Console.WriteLine($"a = {a:F4}");
Console.WriteLine($"b = {b:F4}");
Console.WriteLine($"c = {c}");