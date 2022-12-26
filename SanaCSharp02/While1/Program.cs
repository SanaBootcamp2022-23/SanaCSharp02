namespace While1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            double n;
            Console.Write("Введіть n:");
            n = double.Parse(Console.ReadLine());
            sum1(n);
            sum2(n);
            factorial(n);
        }
        static void sum1(double n) 
        {
            double result = 0;

            while (n > 0) 
            {
                result += Math.Pow(-1, n) / (2 * n + 1);

                n--;
            }
            Console.WriteLine("a = {0}", result);
        }
        static void sum2(double n) 
        {
            double result = 0;
            while (n > 0)
            {
                result += 1 + 1 / (n * n);
                n--;
            }
            Console.WriteLine("b = {0}", result);
        }
        static void factorial(double n) 
        {
            double result=1;
            while (n > 0) 
            {

                result *= n;
                n--;
            }
            Console.WriteLine("c = {0}", result);
        }
    }
}