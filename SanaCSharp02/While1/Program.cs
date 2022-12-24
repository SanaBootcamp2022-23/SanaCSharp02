double a = 0, b = 0, c = 0;

Console.WriteLine("Enter n:");
int n = Convert.ToInt32(Console.ReadLine());


int Factoirial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    return n * Factoirial(n-1);

}

while(n > 0)
{
    a += Math.Pow(-1, n) / (2 * n + 1);
    b += 1 + 1 / Math.Pow(n, 2);
    c += Factoirial(n);
    n--;
}
Console.WriteLine($"A:{a}\nB:{b}\nC:{c}");