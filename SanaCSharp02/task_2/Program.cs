using static System.Math;
double summ = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Введiть {0} оцiнку", i + 1);
    double x = double.Parse(Console.ReadLine());
    summ += x;
}

double res = summ / 5;
if (res >= 4) Console.WriteLine("Допущено");
else Console.WriteLine("Недопущено");