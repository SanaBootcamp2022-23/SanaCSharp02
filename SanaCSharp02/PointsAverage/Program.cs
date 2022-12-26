
using System.Drawing;

class Program
{
    static void Main()
    {
        int PointSum = 0;
        int counter = 1;

        int tempNum;
        while (counter != 6)
        {
            
            Console.Write("Point " + counter + ": ");

            tempNum = Int32.Parse(Console.ReadLine());
            if (tempNum <= 0)
            {
                Console.WriteLine("point cant be zero or less");
                continue;
            }
            else
            {
                PointSum += tempNum;
                counter++;
            }
        }

        if (PointSum / 5 >= 4)
        {
            Console.WriteLine("student is admitted");
        }
        else
        {
            Console.WriteLine("student is not admitted");
        }
        
    }
}