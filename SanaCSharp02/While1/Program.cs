Console.Write("Enter number: ");
int n = Convert.ToInt32(Console.ReadLine());
double a = 0;
double b = 0;
double c = 0;
int f = 1, fn = n;
while (fn > 0)
{
    f *= fn;
    fn--;
}
while (n >= 1)
{
    a += Math.Pow(-1, n) / (2 * n + 1);
    b += 1 + 1 / (double)(n * n);
    c += f;
    f /= n;
    n--;
}
Console.WriteLine("A = " + a);
Console.WriteLine("B = " + b);
Console.WriteLine("C = " + c);