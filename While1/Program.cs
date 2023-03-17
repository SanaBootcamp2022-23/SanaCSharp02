double a = 0, b = 0, c = 0;
int i = 1, n, r = 1, j = 1;
Console.Write("n:");
n = Convert.ToInt32(Console.ReadLine());
while (i <= n)
{
    a = a + Double.Pow(-1, n) / (2 * n + 1);
    b = b + (1 + 1 / (n * n));
    while (j <= i)
    {
        r = r * j;
        j++;
    }
    c = c + r;
    i++;
    j = 1;
    r = 1;
}
Console.WriteLine($"a = {a} \nb = {b} \nc = {c}");
