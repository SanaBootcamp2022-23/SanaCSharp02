double D, x1, x2;

Console.WriteLine("Enter A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter C:");
int c = Convert.ToInt32(Console.ReadLine());

D = Math.Pow(b, 2) - 4 * a * c;

if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"X1:{x1}\nX2:{x2}");
}
else if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"X:{x1}");
}
else
{
    Console.WriteLine("No solutions :(");
}