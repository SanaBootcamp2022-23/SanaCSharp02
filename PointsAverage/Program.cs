using System.Text;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double mark1, mark2, mark3, mark4, mark5, avVal;
            Console.WriteLine("Введення ваших оцінок");
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            mark5 = double.Parse(Console.ReadLine());
            avVal = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;
            if (avVal >= 4) Console.WriteLine("\nВітаємо, ви здобули допуск до екзамену");
            else Console.WriteLine("\nНа жаль, вам не надано допуску до екзамену");
        }
    }
}