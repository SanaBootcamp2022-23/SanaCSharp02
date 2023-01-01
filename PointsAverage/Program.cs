class Program

{
    static void Main(string[] agrs)
    {
    Console.Write("a = ");

     double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");

    double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c = ");

    double c = Convert.ToDouble(Console.ReadLine());

        Console.Write("a = ");

    double d = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");

    double f = Convert.ToDouble(Console.ReadLine());

       double x = (a + b + c + d + f) / 5;

        if(x>=4)
        {
            Console.Write("Середня оцінка студента = " + x + "\nДопущений");
        }

        if (x < 4)
        {
            Console.Write("Середня оцінка студента = " + x + "\nНе допущений");
        }

    }

}