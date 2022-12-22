// See https://aka.ms/new-console-template for more information
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        {
            int[] O = new int[5];
            for (int i = 0; i < O.Length; i++)
            {
                Console.Write($"Введіть {i + 1} оцінку студента ");
                O[i] = int.Parse(Console.ReadLine());
            }
            if (O.Average() >= 4)
                Console.WriteLine("Студент допущений до екзамену");
            else
                Console.WriteLine("Студент не допущений до екзамену");
            Console.ReadLine();
        }
    }
}
