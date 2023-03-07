using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        double mark1, mark2, mark3, mark4, mark5, res;

        Console.WriteLine($"Введіть першу оцінку");
        mark1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введіть другу оцінку");
        mark2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введіть третю оцінку");
        mark3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введіть четверту оцінку");
        mark4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введіть п'яту оцінку");
        mark5 = Convert.ToDouble(Console.ReadLine());

        res = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;

        if (res >= 4)
        {
            Console.WriteLine($"Студент допущений до екзамену");
        }
        else 
        {
            Console.WriteLine($"Студент не допущений до екзамену");
        }
    }
}