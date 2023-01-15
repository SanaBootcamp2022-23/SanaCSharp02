using System;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            int num;
            Console.Write("Введіть число від 1 до 9: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    {
                        Console.Write("Нуль");
                        break;
                    }
                case 1:
                    {
                        Console.Write("Один");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Два");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Три");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Чотири");
                        break;
                    }
                case 5:
                    {
                        Console.Write("П'ять");
                        break;
                    }
                case 6:
                    {
                        Console.Write("Шість");
                        break;
                    }
                case 7:
                    {
                        Console.Write("Сім");
                        break;
                    }
                case 8:
                    {
                        Console.Write("Вісім");
                        break;
                    }
                case 9:
                    {
                        Console.Write("Дев'ять");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Значення не належить діапазону від 1 до 9!");
                        break;
                    }
            }
        }
    }
}


