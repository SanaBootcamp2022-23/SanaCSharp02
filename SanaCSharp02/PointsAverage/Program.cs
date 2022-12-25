using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
int a, b, c, d, f, sum;

Console.WriteLine("Введіть 1 оцінку:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть 2 оцінку:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть 3 оцінку:");
c = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть 4 оцінку:");
d = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть 5 оцінку:");
f = int.Parse(Console.ReadLine());
sum = (a + b + c + d + f) / 5 ;
    if (sum >= 4)

    {
        Console.WriteLine("Допуск отримано, оцінка: {0}", sum);
    }
        else
        {
            Console.WriteLine("Допуск не отримано, оцінка: {0}", sum);
        }