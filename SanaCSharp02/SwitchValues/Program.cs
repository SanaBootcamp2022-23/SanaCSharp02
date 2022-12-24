using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Введіть число з діапазону [0, 9]: ");
sbyte number = sbyte.Parse(Console.ReadLine());
string strNumber;
switch (number)
{
    case 0: strNumber = "Нуль"; break;
    case 1: strNumber = "Один"; break;
    case 2: strNumber = "Два"; break;
    case 3: strNumber = "Три"; break;
    case 4: strNumber = "Чотири"; break;
    case 5: strNumber = "П'ять"; break;
    case 6: strNumber = "Шість"; break;
    case 7: strNumber = "Сім"; break;
    case 8: strNumber = "Вісім"; break;
    case 9: strNumber = "Дев'ять"; break;
    default: strNumber = "Ви ввели число не із діапазону!"; break;
}
Console.Write(strNumber);