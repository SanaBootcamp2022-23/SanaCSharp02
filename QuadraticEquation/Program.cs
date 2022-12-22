float a, b, c, x1, x2, D;
Console.Write("a = ");
a = float.Parse(Console.ReadLine());
Console.Write("b = ");
b = float.Parse(Console.ReadLine());
Console.Write("c = ");
c = float.Parse(Console.ReadLine());
D = (float)(Math.Pow(b, 2) - 4 * a * c);
Console.WriteLine($"Discriminant = {D}");
if (D > 0)
{
    x1 = (float)(((-b) - Math.Sqrt(D)) / 2 * a);
    x2 = (float)(((-b) + Math.Sqrt(D)) / 2 * a);
    Console.WriteLine($"Discriminant is positive, so \nx1 = {x1}\nx2 = {x2}");
}
else if (D == 0)
{
    x1 = -b / (2 * a);
    Console.WriteLine($"Discriminant = 0, so\nx = {x1}");
}
else Console.WriteLine("Discriminant negative, so no possible answer");