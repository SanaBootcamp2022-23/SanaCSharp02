namespace SwitchValues
{
    internal class Program
    {
        public static string ToString(int i)
        {
            return i switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                _ => throw new Exception()
            };
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            Console.Write($"{ToString(int.Parse(Console.ReadLine() ?? ""))}");
        }
    }
}