using System;
using System.Text;

namespace SwitchValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть число від 0 до 9: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("нуль");
                    break;

                case 1:
                    Console.WriteLine("один");
                    break;

                case 2:
                    Console.WriteLine("два");
                    break;

                case 3:
                    Console.WriteLine("три");
                    break;

                case 4:
                    Console.WriteLine("чотири");
                    break;

                case 5:
                    Console.WriteLine("п'ять");
                    break;

                case 6:
                    Console.WriteLine("шість");
                    break;

                case 7:
                    Console.WriteLine("сім");
                    break;

                case 8:
                    Console.WriteLine("вісім");
                    break;

                case 9:
                    Console.WriteLine("дев'ять");
                    break;

                default:
                    Console.WriteLine("Число має бути в діапазоні [0,9]");
                    break;
            }
        }
    }
}