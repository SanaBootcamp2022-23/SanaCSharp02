using System;

namespace PointsAverage
{
    class PointsAverage
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Input num: ");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("1 - one");
                        break;
                    case 2:
                        Console.WriteLine("2 - two");
                        break;
                    case 3:
                        Console.WriteLine("3 - three");
                        break;
                    case 4:
                        Console.WriteLine("4 - four");
                        break;
                    case 5:
                        Console.WriteLine("5 - five");
                        break;
                    case 6:
                        Console.WriteLine("6 - six");
                        break;
                    case 7:
                        Console.WriteLine("7 - seven");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice.");
                        break;
                }
                
            } while (num != 0);          
                                          
        }
                
    }
}
    

