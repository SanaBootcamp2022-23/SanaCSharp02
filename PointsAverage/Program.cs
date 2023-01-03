double a , m = 0;
for(int i = 0; i < 5; i++)
{
    a = double.Parse(Console.ReadLine());
    m += a;
}
a = m / 5;
if (a >= 4)
    Console.WriteLine("Допуск");
else Console.WriteLine("Недопуск");