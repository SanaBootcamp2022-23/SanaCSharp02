using static System.Math;
Console.WriteLine("Введiть число");
double n = double.Parse(Console.ReadLine());

double a = 0;
double b = 0;
double c = 0;
double summ = 1;

for (int i = 1; i < n + 1; i++)
{
    a += Pow(-1, i) / (2 * i + 1);
}
Console.WriteLine("A = {0}", a);

for (int i = 1; i < n + 1; i++)
{
    b += 1 + 1 / Pow(i, 2);
}
Console.WriteLine("B = {0}", b);

for (int i = 1; i < n + 1; i++)
{
    summ = 1;
    for (int j = 1; j < i + 1; j++)
    {
        summ *= j;
    }
    c += summ;
}
Console.WriteLine("C = {0}", c);