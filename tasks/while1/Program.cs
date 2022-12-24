using System;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            Console.WriteLine("Enter n1");
            n1 = double.Parse(Console.ReadLine());

            //for1
            double s1=0, s2=0, s3=0;
            for (int i = 1; i <= n1; i++)
            {
                double a = (Math.Pow(-1, i)) / (2 * i + 1);
                s1 += a;
            }
            Console.WriteLine($"S1 = {s1}");
            //for2
            for (int i = 1; i <= n1; i++)
            {
                double a = 1+(1.0/(i*i));
                s2 += a;
            }
            Console.WriteLine($"S2 = {s2}");
            //for3
            double ins = 1;
            for (int i = 1; i <= n1; i++)
            {
                ins *= i;
                s3 += ins;
            }
            Console.WriteLine($"S3 = {s3}");
        }
    }
}
