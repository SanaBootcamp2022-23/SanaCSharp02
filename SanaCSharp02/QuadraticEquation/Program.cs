// ax^2 + bx + c = 0

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

double a, b, c;

do
{
    Console.Write("Enter 'a': ");
    if (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'a': ");
    }
    else
    {
        Console.WriteLine("The number 'a' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out a));

do
{
    Console.Write("Enter 'b': ");
    if (!double.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'b': ");
    }
    else
    {
        Console.WriteLine("The number 'b' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out b));

do
{
    Console.Write("Enter 'c': ");
    if (!double.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Something went wrong!");
        Console.Write("Repeat entering 'c': ");
    }
    else
    {
        Console.WriteLine("The number 'c' is entered correctly!");
        break;
    }
} while (!double.TryParse(Console.ReadLine(), out c));

double Discriminant = b * b - 4 * a * c;
Console.WriteLine($"The descriminant is {Math.Round(Discriminant, 2)}");

if(Discriminant > 0)
{
    double x1 = (-b - Discriminant) / 2 * a;
    double x2 = (-b + Discriminant) / 2 * a;

    Console.WriteLine($"2 real solutions!\nx1 = {Math.Round(x1, 2)}; x2 = {Math.Round(x2, 2)}");
} 

if(Discriminant < 0)
    Console.WriteLine("The equation has no solutions!");

if(Discriminant == 0)
{
    double x = -b / 2 * a;

    Console.WriteLine($"1 real solution!\nx = {Math.Round(x, 2)}");
}