double a, b, c, x1, x2, x3, D;

Console.Write("Введiть число а: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введiть число b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введiть число c: ");
c = Convert.ToDouble(Console.ReadLine());

D = Math.Pow(b, 2) - 4 * a * c;

Console.WriteLine($"D = {D}");

if (D > 0)
{
    x1 = (-b + Math.Sqrt(D)) / (2 * a);
    x2 = (-b - Math.Sqrt(D)) / (2 * a);

    Console.WriteLine($"x1 = {x1}");
    Console.WriteLine($"x2 = {x2}");
}

else if (D == 0)
{
    x3 = -b * 2 * a;
    Console.WriteLine($"x3 = {x3}");
}

else Console.WriteLine("Коренiв немає");


Console.ReadLine(); //щоб консоль не закривалася відразу