using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
double sum = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write($"{i}-оцінка = ");
    sum += int.Parse(Console.ReadLine());
}
sum /= 5;
if (sum >= 4) Console.WriteLine($"Допущений. {sum}");
else Console.WriteLine($"Не допущений. {sum}");