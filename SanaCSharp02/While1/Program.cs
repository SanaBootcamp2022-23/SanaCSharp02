double fact(int N)
{
    if (N < 0) 
        return 0; 
    if (N == 0) 
        return 1;
    else 
        return N * fact(N - 1);
}

int n;
double a=0, b=0, c=0;
Console.WriteLine("Введiть n");
n = Convert.ToInt16(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double s;
    s = Math.Pow(-1, i) / (2 * i + 1);
    a += s;
}
for (int i = 1; i <= n; i++)
{
    double s;
    s = 1 + (1 / Math.Pow(i,2));
    b += s;
}
for (int i = 1; i <= n; i++)
{
    double s;
    s = fact(i);
    c += s;
}
Console.WriteLine("Введiть a "+a);
Console.WriteLine("Введiть b "+b);
Console.WriteLine("Введiть c "+c);
