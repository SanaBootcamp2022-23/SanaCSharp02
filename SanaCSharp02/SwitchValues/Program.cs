using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int value;
Console.Write("Введіть число [0;9]: "); value = int.Parse(Console.ReadLine());
switch (value)
{
    case 0: Console.Write("0 - нуль"); break;
    case 1: Console.Write("1 - один"); break;
    case 2: Console.Write("2 - два"); break;
    case 3: Console.Write("3 - три"); break;
    case 4: Console.Write("4 - чотири"); break;
    case 5: Console.Write("5 - п’ять"); break;
    case 6: Console.Write("6 - шість"); break;
    case 7: Console.Write("7 - сім"); break;
    case 8: Console.Write("8 - вісім"); break;
    case 9: Console.Write("9 - дев’ять"); break;
}