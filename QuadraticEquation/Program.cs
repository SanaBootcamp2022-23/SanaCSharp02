namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0,
                  b = 0,
                  c = 0;
            bool isSuccess = false;
            float result = 0;
            Console.WriteLine("Quadratic Exquation solver");
            Console.WriteLine("Please enter 3 values");
            while (!isSuccess)
            {
                try
                {
                    Console.Write("a:");
                    a = float.Parse(Console.ReadLine());

                    Console.Write("b:");
                    b = float.Parse(Console.ReadLine());

                    Console.Write("c:");
                    c = float.Parse(Console.ReadLine());
                    isSuccess = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Please enter 3 values");
                }
            }
            float D = (float)(Math.Pow(b, 2) - 4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("There's no valid roots");
            }
            else if (D == 0)
            {
                Console.WriteLine("The equation has 2 equal roots");
                float x = -(b) / (2 * a);
                Console.WriteLine($"x: {x}");
            }
            else if (D > 0)
            {
                Console.WriteLine("The equation has two different roots");
                float x1 = (float)(-b + Math.Sqrt(D)) / (2 * a);
                float x2 = (float)(-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1:{x1}");
                Console.WriteLine($"x2:{x2}");
            }
        }
    }
}