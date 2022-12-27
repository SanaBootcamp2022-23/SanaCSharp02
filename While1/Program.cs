namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double a = 0;
            double b = 0;
            int c = 1;
            for (int i = 1; i <= n; i++)
            {
                c *= i;
            }
            for (int i = 1; i < n; i++)
            {
                a += Math.Pow(-1.0, i) / (2.0 * i + 1);
                b += 1 + 1.0 / Math.Pow(i, 2);
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}