using static System.Math;
Console.WriteLine("Введiть занчення змiнних для виразу:");
double a, b, c, d;
Console.Write("a: "); a = double.Parse(Console.ReadLine());
Console.Write("b: "); b = double.Parse(Console.ReadLine());
Console.Write("c: "); c = double.Parse(Console.ReadLine());
double dis = Pow(b, 2) - 4 * a * c;
double sqdis = Sqrt(dis);
if (dis > 0)
{
    double x1 = (-b - sqdis) / 2 * a;
    double x2 = (-b + sqdis) / 2 * a;
    Console.WriteLine("Перший корiнь дискрiмiнанта = {0}.\n Другий корiнь дискримiнанта = {1}", x1, x2);
}

if (dis == 0)
{
    double x1 = (-b) / 2 * a;
    Console.WriteLine("Корiнь дискрiмiнанта = {0}.\n", x1);
}

if (dis < 0)
{
    Console.WriteLine("Коренiв немає");
}