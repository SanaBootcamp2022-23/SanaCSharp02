int a;
Console.Write("Будь ласка, введiть цiле число у дiапазонi [0, 9] - ");
a = Convert.ToInt16(Console.ReadLine());

if (a >= 0 && a <= 9)
{
    switch (a)
    {
        case 0: Console.WriteLine("Нуль"); break;
        case 1: Console.WriteLine("Один"); break;
        case 2: Console.WriteLine("Два"); break;
        case 3: Console.WriteLine("Три"); break;
        case 4: Console.WriteLine("Чотири"); break;
        case 5: Console.WriteLine("П'ять"); break;
        case 6: Console.WriteLine("Шiсть"); break;
        case 7: Console.WriteLine("Сiм"); break;
        case 8: Console.WriteLine("Вiсiм"); break;
        case 9: Console.WriteLine("Дев'ять"); break;

    }
}
else
    Console.WriteLine("Ви ввели некоректне значення. Спробуйте ще раз");

Console.ReadLine(); //щоб консоль не закривалася відразу
