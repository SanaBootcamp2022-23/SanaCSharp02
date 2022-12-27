using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp02
{
    class Program
    {
        private static double а;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = UTF8Encoding.UTF8;
            int a = 0;
            do
            {
                Console.WriteLine(" Введіть число з діапазона [0;9]");
                Console.WriteLine(" Для виходу з програми введіть -1");
                a = int.Parse(Console.ReadLine());
                if (a < 0 || a > 9)
                {
                    Console.WriteLine(" Число не входить в заданий діапазон\n ");
                    goto exit;
                }
                switch (a)
                {
                    case 0:
                        {
                            Console.WriteLine(" нуль\n");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine(" один\n");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" два\n");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" три\n");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(" чотири\n");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine(" п'ять\n");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine(" шість\n");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine(" сім\n");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine(" вісім\n");
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine(" дев'ять\n");
                            break;
                        }
                }
            } while (a != -1);
        exit: Console.WriteLine();
        }
    }
}