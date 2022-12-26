using System;

namespace SwitchValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 0: Console.WriteLine("Нуль");break;
                case 1: Console.WriteLine("Один");break;
                case 2: Console.WriteLine("Два");break;
                case 3: Console.WriteLine("Три");break;
                case 4: Console.WriteLine("Чотири");break;
                case 5: Console.WriteLine("П'ять");break;
                case 6: Console.WriteLine("Шість");break;
                case 7: Console.WriteLine("Сім");break;
                case 8: Console.WriteLine("Вісім");break;
                case 9: Console.WriteLine("Дев'ять");break;
            }
        }
    }
}
