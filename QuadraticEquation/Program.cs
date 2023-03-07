using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double a, b, c, d ,x1, x2;

        Console.WriteLine($"Увведіть перше число");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Увведіть друге число");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Увведіть третє число");
        c = Convert.ToDouble(Console.ReadLine());

        d = (Math.Pow(-b, 2)) - (4 * a * c);
        Console.WriteLine($"Дискримінант = {d}");

        if( d > 0 )
        {
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if(d == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine($"x1 = {x1}");
        }
        else 
        {
            Console.WriteLine($"Немає коренів");
        }
    }
}