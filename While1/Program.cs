// See https://aka.ms/new-console-template for more information
internal class Program
{
    private static void Main(string[] args)
    {
        double a = 0, b = 0, c = 0;
        int n,factorial = 1;
        Console.Write("Enter the number: ");
        n=int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            a += Math.Pow(-1, i) / (2 * i + 1);
            b += 1 + (1 / Math.Pow(i, 2));
            factorial *= i;
            c += factorial;
        }
        Console.WriteLine($"A = {a}\nB = {b}\nC = {c}");
    }
}
