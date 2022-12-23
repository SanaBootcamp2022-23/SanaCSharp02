
int a = 0, b = 0, c = 0;
double discriminant;

bool isRightNumber;

CheckAndWriteNumber(out a, "a");
CheckAndWriteNumber(out b , "b");
CheckAndWriteNumber(out c, "c");

void CheckAndWriteNumber(out int number, string str)
{
    do
    {
        Console.Write($"Input {str}: ");
        isRightNumber = int.TryParse(Console.ReadLine(), out number);
        if (!isRightNumber)
        {
            Console.Write("ERROR!!!\n");
        }
    } while (!isRightNumber);
}

discriminant = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"\nDiscriminant = {discriminant}\n");

if (discriminant > 0)
{
    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

    Console.WriteLine($"x1 = {x1}\nx2 = {x2}", "F3");
}
else if (discriminant == 0)
{
    double x = (-b) / (2 * a);
    Console.WriteLine($"x1 = {x}", "F3");
}
else
{
    Console.WriteLine("There is no solution.");
}
