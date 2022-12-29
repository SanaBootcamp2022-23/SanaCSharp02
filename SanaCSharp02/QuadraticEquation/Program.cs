using System;
using System.Text;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //
            double a, b, c, D, x1, x2;
            //
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.WriteLine("\nВиконав: Радченко Д.В\n");

            do
            {
                Console.Write("Input а = ");
                if (double.TryParse(Console.ReadLine(), out a)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            }
            while (true);
            do
            {
                Console.Write("Input b = ");
                if (double.TryParse(Console.ReadLine(), out b)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            } while (true);
            do
            {
                Console.Write("Input c = ");
                if (double.TryParse(Console.ReadLine(), out c)) break;
                else { Console.WriteLine(" Error while inputing,pls rewrite correctly"); }
            } while (true);

            Console.Write("\na ={0}", a);
            Console.Write("\nb ={0}", b);
            Console.Write("\nc ={0}", c);
            Console.Write("\nРівняння = {0}x^2+{1}x+{2}", a, b, c);
            Console.Write("\n*********************\n");
            D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Рівняння немає розв'язку,тому що D<0");
            }
            else
            {
                Console.WriteLine("Дискримінант(D) = {0}", D);
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("перший корінь дорівнює--> x1 = {0}", x1);
                Console.WriteLine("перший корінь дорівнює--> x2 = {0}", x2);

            }
            if (D == 0)
            {
                x1 = -(b / (2 * a));
                Console.WriteLine("Дискримінант(D) = 0, тому--> x=-(b / (2 * a))={0} ", x1);
            }


            Console.ReadKey();
        }
    }
}
