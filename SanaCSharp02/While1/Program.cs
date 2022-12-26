int  n;
double a = 0, b = 0, c=1,res=0;

Console.WriteLine("Enter number [0;9]");
n=int.Parse(Console.ReadLine());

int i = 1;
while(i<=n)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += (1 + 1 / Math.Pow(i, 2));
    c *= i;
    res += c;
    i++;
}
Console.WriteLine($"a={a}, b={b}, c={res}");


