Console.Write("Enter n:");
int n;
n = Convert.ToInt32(Console.ReadLine());

double a = 0, b = 0, c = 0, f = 1;
int i = 1;

while (i <= n)
{
    a += Math.Pow((-1), i)/(2 * i+1);
    b += 1 + (1 / i * i);
    f *= i;
    c += f;

    i++;
}
Console.WriteLine("a={0}\nb={1}\nc={2}", a, b, c);