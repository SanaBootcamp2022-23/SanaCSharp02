double a, b, c, delta, x, x1, x2;
Console.WriteLine("Program to find Quadratic Equation");
Console.Write("Enter a: ");
a = double.Parse(Console.ReadLine());
Console.Write("Enter b: ");
b = double.Parse(Console.ReadLine());
Console.Write("Enter c: ");
c = double.Parse(Console.ReadLine());
delta = b * b - 4 * a * c;
Console.WriteLine("Delta = " + Math.Sqrt(delta));
if (delta < 0)
    Console.WriteLine("Delta < 0. Solving doesn`t exist!");
if (delta == 0) {
    x = (-b) / 2 * a;
    Console.WriteLine("\nResult:\n x = " + x);
}
if (delta > 0) {
    x1 = ( (-b) + Math.Sqrt(delta)) / (2 * a);
    x2 = ( (-b) - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("\nResult:\nx1 = " + x1 + "\nx2 = " + x2);
}
