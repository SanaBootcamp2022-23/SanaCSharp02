using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
while (true)
{
    Console.Write("Число = ");
    int i = int.Parse(Console.ReadLine());
    switch (i)
    {
        case 0: Console.WriteLine($"{i} = Нуль"); break;
        case 1: Console.WriteLine($"{i} = Один"); break;
        case 2: Console.WriteLine($"{i} = Два"); break;
        case 3: Console.WriteLine($"{i} = Три"); break;
        case 4: Console.WriteLine($"{i} = Чотири"); break;
        case 5: Console.WriteLine($"{i} = П'ять"); break;
        case 6: Console.WriteLine($"{i} = Шість"); break;
        case 7: Console.WriteLine($"{i} = Сім"); break;
        case 8: Console.WriteLine($"{i} = Вісім"); break;
        case 9: Console.WriteLine($"{i} = Дев'ять"); break;
        default: Console.WriteLine("Спробуйте ще раз"); break;
    }
}
