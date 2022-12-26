using System.Text;

namespace SwitchValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int num = 0;
            Console.WriteLine("Введіть ваше число");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("\nНуль");
                    break;
                case 1:
                    Console.WriteLine("\nОдин");
                    break;
                case 2:
                    Console.WriteLine("\nДва");
                    break;
                case 3:
                    Console.WriteLine("\nТри");
                    break;
                case 4:
                    Console.WriteLine("\nЧотири");
                    break;
                case 5:
                    Console.WriteLine("\nП'ять");
                    break;  
                case 6:
                    Console.WriteLine("\nШість");
                    break;
                case 7:
                    Console.WriteLine("\nСім");
                    break;
                case 8:
                    Console.WriteLine("\nВісім");
                    break;
                case 9:
                    Console.WriteLine("\nДев'ять");
                    break;
                default:
                    break;
            }
        }
    }
}