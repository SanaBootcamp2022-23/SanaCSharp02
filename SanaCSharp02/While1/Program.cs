
Console.WriteLine("Enter natural number n:");

double n;
if (!double.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Error! Enter number");
    return;
}

decimal a = 0, b = 0;
double factorial = 1, c = 0;

int i = 1;
while(i <= n)
{
    a += (decimal)Math.Pow((-1), i) / (decimal)(2 * i + 1);
    b += 1 + 1 / (decimal)Math.Pow(i, 2);
    factorial *= i;
    c += factorial;
    i++;
}

Console.WriteLine($"a = {a:F2}");
Console.WriteLine($"b = {b:F2}");
Console.WriteLine($"c = {c}");