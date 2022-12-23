using System;

class Program
{
    public int factorial(int n)
    {
        int res = 1;
        for (int j = 1; j <= n; j++)
        {
            res *= j;
        }
        return res;
    }
    public static void Main(string[] args)
    {
        int n;
        double a=0, b=0, c=0;
        Console.WriteLine("Enter the value of n");
        Console.Write("-> ");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <=n; i++)
        {
            a += Math.Pow(-1, i) / (2.0 * i + 1);
            b += (1 + 1.0 / Math.Pow(i, 2));
            Program fact = new Program();
            c += fact.factorial(i);
        }

        Console.WriteLine($" a -> {a}, b -> {b}, c-> {c}");
    }
}