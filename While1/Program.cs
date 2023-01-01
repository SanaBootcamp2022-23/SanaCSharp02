class Program
{
    static void Main(string[] agrs)
    {
        int factorial = 1;
        int i = 1;

        Console.Write("Введіть значення n : ");

        int  n = int.Parse(Console.ReadLine());

        double a = 0, b = 0, c = 0;


        while (i <= n) 
        {
            a += (Math.Pow(-1,i )) / (2 * i + 1);
            b += (1 + (1 / (Math.Pow(i, 2))));
            factorial *= i;
            c += factorial;
            i++;
        }

        Console.Write("a = " + a);
        Console.Write("\nb = " + b);
        Console.Write("\nc = " + c);
    }
}
