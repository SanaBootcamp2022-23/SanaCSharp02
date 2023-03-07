using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        int number;

        Console.WriteLine($"Введіть цифру від 0 до 9");
        number = Convert.ToInt32(Console.ReadLine());

        switch (number) 
        {
            case 0:
                Console.WriteLine($"{number} - нуль");
                    break;
            case 1:
                Console.WriteLine($"{number} - один");
                break;
            case 2:
                Console.WriteLine($"{number} - два");
                break;
            case 3:
                Console.WriteLine($"{number} - три");
                break;
            case 4:
                Console.WriteLine($"{number} - чотири");
                break;
            case 5:
                Console.WriteLine($"{number} - п'ять");
                break;
            case 6:
                Console.WriteLine($"{number} - шість");
                break;
            case 7:
                Console.WriteLine($"{number} - сім");
                break;
            case 8:
                Console.WriteLine($"{number} - вісім");
                break;
            case 9:
                Console.WriteLine($"{number} - дев'ять");
                break;
            default:
                Console.WriteLine($"Введено число менше 0 ,або більше 9");
                break;
        }
    }
}