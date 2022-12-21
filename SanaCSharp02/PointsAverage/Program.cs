using System;
using System.Text;
using System.Transactions;

namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int total = 0;
            Console.WriteLine("Введіть ваші оцінки: ");
            for (int i = 0; i < 5; i++)
            {
                int mark = int.Parse(Console.ReadLine());
                total += mark;
            }
            total /= 5;
            if(total > 4)
            {
                Console.WriteLine("Допущено");
            }
            else
            {
                Console.WriteLine("Не допущено");
            }
        }
    }
}