double a, b, c, x1, x2, x3, D;
Console.WriteLine("Введiть а:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть b:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введiть c:");
c = Convert.ToDouble(Console.ReadLine());
D = (b * b) - (4 * a * c);
Console.WriteLine("Дискримінант = " + D);
if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine("x1 = " + x1);
    Console.WriteLine("x2 = " + x2);
}
else if (D == 0)
{
    x3 = -b / (2 * a);
    Console.WriteLine("Вiдповідь: " + x3);
}
else
{
    Console.WriteLine("Розвязків немає");
}