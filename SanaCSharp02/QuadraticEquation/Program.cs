// See https://aka.ms/new-console-template for more information

double a, b, c, d, x1, x2, x;
Console.Write("Введіть a = ");
a = double.Parse(Console.ReadLine());
Console.Write("Введіть b = ");
b = double.Parse(Console.ReadLine());
Console.Write("Введіть c = ");
c = double.Parse(Console.ReadLine());

d = Math.Pow(b, 2) - 4 * a * c;
if (d > 0)
{
    x1 = (-b + Math.Sqrt(d)) / (2 * a);
    x2 = (-b - Math.Sqrt(d)) / (2 * a);
    Console.WriteLine("Квадратне рівняння має 2 розвязки:\n" + x1 + "\n" + x2);
}
else if (d == 0)
{


    x = -b / (2 * a);

    Console.WriteLine("Квадратне рівняння має 1 розвязок:\n" + x);
}

else
    Console.WriteLine("Коренів немає");
