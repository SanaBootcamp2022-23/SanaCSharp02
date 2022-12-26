
class Program
{
    static void Main()
    {
        Console.WriteLine("ax^2 + bx + c = 0");
        Console.Write("input num a: ");
        double numberA = Double.Parse(Console.ReadLine());
        Console.Write("input num b: ");
        double numberB = Double.Parse(Console.ReadLine());
        Console.Write("input num c: ");
        double numberC = Double.Parse(Console.ReadLine());

        double discriminant;
        discriminant = Math.Pow(numberB, 2) - (4 * numberA * numberC);

        
        while(numberA == 0)
        {
            Console.WriteLine("if number a equal zero it's not a quadratic equation");
            Console.Write("input num a: ");
            numberA = Double.Parse(Console.ReadLine());
        }

        double x1;
        double x2;
        if (discriminant < 0)
        {
            Console.WriteLine(discriminant);
            Console.WriteLine("discriminant is less than zero");
        } else
        {
            Console.WriteLine(discriminant);
            x1 = ((numberB * -1) - Math.Sqrt(discriminant)) / (2 * numberA);
            x2 = ((numberB * -1) + Math.Sqrt(discriminant)) / (2 * numberA);

            Console.WriteLine("x1: " + x1);
            Console.WriteLine("x2: " + x2);
        }



    }
}