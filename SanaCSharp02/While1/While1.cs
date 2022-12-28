using System;

namespace QuadraticEquation
{
    class While1
    {
        static void Main(string[] args)
        {
            int n;
            double a = 0, b = 0, c = 1;
            Console.WriteLine("Input num ");
            do {
                n = Convert.ToInt32(Console.ReadLine());
                a = a + Math.Pow((-1), n)/(2*n+1);
                Console.WriteLine("a : {0:f2}",a);
                b =  b + (1+(1/Math.Pow(2, n)));
                Console.WriteLine("b : {0:f2}",b);
                for (int i = 1; i <= n; i++)
                { 
                    c *= i;           
                }
                c/= n;
                Console.WriteLine("c = {0}", c);
            }
            while (n!=0);
        }
    }
}
