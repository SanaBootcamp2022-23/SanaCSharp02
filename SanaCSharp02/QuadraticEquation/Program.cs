namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());
            double D;
            double x1;
            double x2;

            D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"D = {D}");
            if (D > 0 )
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);

            }
            else if (D == 0)
            {
                double x = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x={x}");
            }
            else
            {
                Console.WriteLine("There are no roots");
            }
        }
    }
}