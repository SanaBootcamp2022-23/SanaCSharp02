using System;

namespace PointsAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            double summ = 0;
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                summ += array[i];
            }
            double avarage = summ / 5;
            Console.WriteLine(avarage);
            if (avarage >= 4)
            {
                Console.WriteLine("Студент отримує допуск");
            }
            else
            {
                Console.WriteLine("Студент не отримує допуск");

            }    
        }
    }
}
