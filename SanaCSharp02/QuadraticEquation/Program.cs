double
     a, b, c, x1, x2, discriminant;
do
{
    Console.WriteLine("Enter the number < a > (< a > not equal to zero)");
    try
    {
        a = double.Parse(Console.ReadLine());
        if (a != 0)
        {
            Console.WriteLine();
            Console.WriteLine();
            break;
        }
        else
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You entered the number zero!!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The program cannot recognize the entered data. Try again ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
    Console.WriteLine();
} while (true);


do
{
    Console.WriteLine("Enter the number < b > ");
    try
    {
        b = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        break;
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The program cannot recognize the entered data. Try again ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
    Console.WriteLine();
} while (true);


do
{
    Console.WriteLine("Enter the number < c > ");
    try
    {
        c = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine();
        break;
    }
    catch (Exception)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The program cannot recognize the entered data. Try again ");
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine();
    Console.WriteLine();
} while (true);

Console.WriteLine("Your quadratic equation : ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"\t  {a}x^");
if (b != 0) Console.Write($" + {b}x");
if (c != 0) Console.Write($" + {c}");
Console.WriteLine(" = 0");

discriminant = b * b - 4 * a * c;


if (discriminant == 0)
{

    x1 = -b / (2 * a);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Discriminant = {discriminant}; ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\t  x = { x1}");
    Console.ForegroundColor = ConsoleColor.White;
}
else if (discriminant > 0)
{
    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);

    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"Discriminant = {discriminant}");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\t  x1 = { x1}");
    Console.WriteLine($"\t  x2 = { x2}");
    Console.ForegroundColor = ConsoleColor.White;

}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Discriminant ={discriminant}, No solutions to the equation ");


    Console.ForegroundColor = ConsoleColor.White;

}
