using System.Text;

namespace SwitchValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int number;
            bool isOk;
            do
            {
                Console.Write($"Введіть число в діапазоні [0; 9]: ");
                isOk = int.TryParse(Console.ReadLine(), out number);
                if (!isOk || (number > 9 || number < 0))
                    Console.WriteLine("Ви помилилися при введені! Спробуйте ще!");
            } while (!isOk || (number > 9 || number < 0));
            switch (number)
            {
                case 0:
                    Console.WriteLine("Нуль");
                    break;
                case 1:
                    Console.WriteLine("Один");
                    break;
                case 2:
                    Console.WriteLine("Два");
                    break;
                case 3:
                    Console.WriteLine("Три");
                    break;
                case 4:
                    Console.WriteLine("Чотири");
                    break;
                case 5:
                    Console.WriteLine("П'ять");
                    break;
                case 6:
                    Console.WriteLine("Шість");
                    break;
                case 7:
                    Console.WriteLine("Сім");
                    break;
                case 8:
                    Console.WriteLine("Вісім");
                    break;
                case 9:
                    Console.WriteLine("Дев'ять");
                    break;
            }
        }
    }
}