using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int num;

Console.Write("Введіть число (0-9):");
num = int.Parse(Console.ReadLine());

switch (num)
{
    case 0:
        Console.Write("\n0 - нуль\n");
        break;
    case 1:
        Console.Write("\n1 - один\n");
        break;
    case 2:
        Console.Write("\n2 - два\n");
        break;
    case 3:
        Console.Write("\n3 - три\n");
        break;
    case 4:
        Console.Write("\n4 - чотири\n");
        break;
    case 5:
        Console.Write("\n5 - п'ять\n");
        break;
    case 6:
        Console.Write("\n6 - шість\n");
        break;
    case 7:
        Console.Write("\n7 - сім\n");
        break;
    case 8:
        Console.Write("\n8 - вісім\n");
        break;
    case 9:
        Console.Write("\n9 - дев'ять\n");
        break;
    default:
        Console.WriteLine("\nТака цифра не передбачена\n");
        break;
}
