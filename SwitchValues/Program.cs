using System.Text;
Console.OutputEncoding = Encoding.UTF8;
int x;

Console.Write("Введіть число x[0,9]:");
x = Convert.ToInt16(Console.ReadLine());
if (x >= 0 && x <= 9)
{

switch(x)
{
    case 0: Console.Write("Нуль"); break;
    case 1: Console.Write("Один"); break;
    case 2: Console.Write("Два"); break;
    case 3: Console.Write("Три"); break;
    case 4: Console.Write("Чотири"); break;
    case 5: Console.Write("П'ять"); break;
    case 6: Console.Write("Шість"); break;
    case 7: Console.Write("Сімь"); break;
    case 8: Console.Write("Вісім"); break;
    case 9: Console.Write("Дев'ять"); break;
    }
}
else
{
    Console.Write("Введення невірне");
}    