using System.Text;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b, c, x1, x2, disc, x;
            Console.WriteLine("Введіть коефіціенти квадратного рівняння");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            disc = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine("\nДискримінант = {0}", disc);
            if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine("\nКорені рівняння: x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (disc == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("\nКорінь рівняння = {0}", x);
            }
            else if (disc < 0) Console.WriteLine("\nКорені рівняння відсутні");
        }
    }
}