class Program
{

    static void Main(string[] agrs)
    {
        Console.Write("a = ");

        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");

        double b = Convert.ToDouble(Console.ReadLine());    

        Console.Write("c = ");
        
        double c = Convert.ToDouble(Console.ReadLine());

        double d = (Math.Pow(b, 2)) - (4 * (a * c));
        if (d > 0)
        {

            double x1 = (((-1) * b) + (Math.Sqrt(d))) / (2 * a);

            double x2 = (((-1) * b) - (Math.Sqrt(d))) / (2 * a);

            Console.Write("x1 = " + x1);

            Console.Write("\nx2 = " + x2);
        }

        if (d == 0)
        {
            double x = (-1) * ((b) / (2 * a));

            Console.Write("x = " + x);
        }

        if (d < 0)
        {
            Console.Write("Розв'язків немає");
        }

    }
 }