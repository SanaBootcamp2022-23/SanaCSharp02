using System;

namespace SwitchValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть число вiд 0 до 9: ");
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
                    Console.WriteLine("п`ять");
                    break;
                case 6:
                    Console.WriteLine("шiсть");
                    break;
                case 7:
                    Console.WriteLine("ciм");
                    break;
                case 8:
                    Console.WriteLine("вiсiм");
                    break;
                case 9:
                    Console.WriteLine("дев`ять");
                    break;
            }
        }
    }
}
