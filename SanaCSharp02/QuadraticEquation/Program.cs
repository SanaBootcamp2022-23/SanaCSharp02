using System.Text;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b, c, D, x1, x2, x;
            bool isOk;
            do
            {
                Console.Write("Введіть значення коефіцієнту 'a': ");
                isOk = double.TryParse(Console.ReadLine(), out a);
                if (!isOk)
                    Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
            } while (!isOk);
            do
            {
                Console.Write("Введіть значення коефіцієнту 'b': ");
                isOk = double.TryParse(Console.ReadLine(), out b);
                if (!isOk)
                    Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
            } while (!isOk);
            do
            {
                Console.Write("Введіть значення коефіцієнту 'c': ");
                isOk = double.TryParse(Console.ReadLine(), out c);
                if (!isOk)
                    Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
            } while (!isOk);
            D = (b * b) - (4 * a * c);
            if (D < 0)
                Console.WriteLine($"Коренів немає!\nДискримінант = {D}");
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}\nДискримінант = {D}");
            }
            else
            {
                x = -b / (2 * a);
                Console.WriteLine($"x = {x}\nДискримінант = {D}");
            }
        }
    }
}