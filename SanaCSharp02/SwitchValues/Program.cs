using System.Text;

namespace PointsAverage
{
    internal class Program
    {
        static void inputNumber(ref int value)
        {
            try
            {
                value = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Введіть число!");
                inputNumber(ref value);
            }
        }
        static void Main(string[] args)
        {
            /*Завдання 3 - створити проект SwitchValues: 
             * з клавіатури вводиться ціле число у діапазоні [0, 9]. 
             * Вивести на екран число прописом. Наприклад: 7 - сім.
             * Використайте оператор switch.*/

            Console.OutputEncoding = Encoding.Unicode; // підключаємо вивід українською мовою
            Console.InputEncoding = Encoding.Unicode; // підключаємо ввід українською мовою

            int value = 0;
            Console.Write("Введіть значення від 0 до 9: ");
            inputNumber(ref value);
            
            switch(value) { 
            case 0: Console.WriteLine("{0} - нуль", value); break;
            case 1: Console.WriteLine("{0} - один", value); break;
            case 2: Console.WriteLine("{0} - два", value); break;
            case 3: Console.WriteLine("{0} - три", value); break;
            case 4: Console.WriteLine("{0} - чотири", value); break;
            case 5: Console.WriteLine("{0} - п'ять", value); break;
            case 6: Console.WriteLine("{0} - шість", value); break;
            case 7: Console.WriteLine("{0} - сім", value); break;
            case 8: Console.WriteLine("{0} - вісім", value); break;
            case 9: Console.WriteLine("{0} - дев'ять", value); break;
            }

        }
    }
}