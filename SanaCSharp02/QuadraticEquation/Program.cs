namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Введіть a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть c:");
            c = int.Parse(Console.ReadLine());

            double D = b * b - 4 * a * c;
            Console.WriteLine($"D = {D}");
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            if (D > 0)
            {
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            else if (D == 0)
            {
                Console.WriteLine("x = {0}", x1);
            }
            else
            {
                Console.WriteLine("Коренів немає");
            }
        }
    }
}