int a;
Console.WriteLine("Введiть число в дiапазонi [0;9]");
a = Convert.ToInt16(Console.ReadLine());
if(a>=0&&a<=9)
{
    switch (a)
    {
        case 0: Console.WriteLine("0-Нуль"); break;
        case 1: Console.WriteLine("1-Один"); break;
        case 2: Console.WriteLine("2-Два"); break;
        case 3: Console.WriteLine("3-Три"); break;
        case 4: Console.WriteLine("4-Чотири"); break;
        case 5: Console.WriteLine("5-П'ять"); break;
        case 6: Console.WriteLine("6-Шiсть"); break;
        case 7: Console.WriteLine("7-Сiм"); break;
        case 8: Console.WriteLine("8-Вiсiм"); break;
        case 9: Console.WriteLine("9-Дев'ять"); break;

    }
}
else
    Console.WriteLine("Невірне значення");










