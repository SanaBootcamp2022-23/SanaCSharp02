class Program
{
    static void Main()
    {
        double a, b, c, D, x, x1, x2;
        Console.WriteLine("Enter first number a: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number c: ");
        c = double.Parse(Console.ReadLine());
        D = Math.Pow(b, 2) - 4 * a * c;
        Console.WriteLine($"D = {D}");
        if (D < 0) 
        {
            Console.WriteLine("The equation hasn`t solution!");
        }
        else if (a > 0)
        {
            if (D == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine($"X = {x}");
            }
            else if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"X1 = {x1}\nX2 = {x2}");
            }
        }
        else
        {
            Console.WriteLine("The equation hasn`t solution!");
        }
    }
}