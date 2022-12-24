namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число:");
            int n = int.Parse(Console.ReadLine());
            double a = 0, b = 0, c = 0, f = 1;

            for (int i = 1; i <= n; i++)
            {
                a += Math.Pow(-1, i) / (2 * i + 1);
                b += 1 + 1 / Math.Pow(i, 2);
                f *= i;
                c += f;  
            }
            Console.WriteLine($"a = {a}\nb = {b}\nc = {c}");
        }
    }
}