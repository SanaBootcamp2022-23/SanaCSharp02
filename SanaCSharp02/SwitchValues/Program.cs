


class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.Write("Num: ");
            int number = Int32.Parse(Console.ReadLine());
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
                default:
                    Console.WriteLine("I dont know about this numberа");
                    break;
                
            }
        }
    }
}