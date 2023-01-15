using System;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            double point, avr, sum = 0;
            int count = 5;
            Console.WriteLine("Введіть 5 оцінок: ");
            for (int i = 0; i < count; i++)
            {
                point = double.Parse(Console.ReadLine());
                sum += point;
            }
            avr = sum / count;
            Console.WriteLine($"Сума оцінок = {sum}");
            Console.WriteLine($"Середній бал студента = {avr}");
            if (avr >= 4)
            {
                Console.WriteLine("Середній бал вище за 4. Його допущено до екзамену.");
            }
            else
            {
                Console.WriteLine("Середній бал нижче за 4. Його не допущено до екзамену.");
            }
        }
    }
}

