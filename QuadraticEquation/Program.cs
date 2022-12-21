
double a, b, c, d, x1, x2;

Console.Write("Будь-ласка введiть число a: ");
a = double.Parse(Console.ReadLine());
Console.Write($"було введено а= {a}\n");
Console.Write("Будь-ласка введiть число b: ");
b = double.Parse(Console.ReadLine());
Console.Write($"було введено b= {b}\n");
Console.Write("Будь-ласка введiть число c: ");
c = double.Parse(Console.ReadLine());
Console.Write($"було введено c= {c}\n");

d = b * b - 4 * a * b;
if (d > 0)
{
    x1 = (-b - Math.Sqrt(d)) / (2 * a);
    x2 = (-b + Math.Sqrt(d)) / (2 * a);
    Console.Write($"Перший корiнь х1={x1}\n");
    Console.Write($"другий корiнь х2={x2}\n");
}
if (d == 0)
{
    x1 = -b / (2 * a);
    Console.Write($"Єдиний корiнь х={x1}\n");
}
if(d<0)
{
    Console.WriteLine("На жаль розв'язкiв тут немаємо ....");

}