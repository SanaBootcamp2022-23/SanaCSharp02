using System;

namespace PointsAverage
{
    class PointsAverage
    {
        static void Main(string[] args)
        {
            double m1,m2,m3,m4,m5;
            double average = 0.0;

            Console.Write("Please enter a Mark1: ");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter a Mark2: ");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter a Mark3: ");
            m3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter a Mark4: ");
            m4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter a Mark5: ");
            m5 = Convert.ToDouble(Console.ReadLine());

            average = (m1 + m2 + m3 + m4 + m5) / 5;

            if (average < 4)
            {
                Console.WriteLine("Student not allowed to exam : {0}", average);
            }
            else
            {
                Console.WriteLine("The student is admitted to the exam!!  : {0}", average);
            }
        }
    }
}
