class Program
{

    static void Main(string[] agrs)
    {

        Console.Write("Введіть число в діапазоні від 0 до 9: ");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 9 && num >= 0)

         {

            switch (num)

            {
                case 0:
                    {
                        Console.Write("0 - нуль");
                        break;
                    }
                case 1:
                    {
                        Console.Write("1 - один");
                        break;
                    }
                case 2:
                    {
                        Console.Write("2 - два");
                        break;
                    }
                case 3:
                    {
                        Console.Write("3 - три");
                        break;
                    }
                case 4:
                    {
                        Console.Write("4 - чотири");
                        break;
                    }
                case 5:
                    {
                        Console.Write("5 - п'ять");
                        break;
                    }
                case 6:
                    {
                        Console.Write("6 - шість");
                        break;
                    }
                case 7:
                    {
                        Console.Write("7 - сім");
                        break;
                    }
                case 8:
                    {
                        Console.Write("8 - вісім");
                        break;
                    }
                case 9:
                    {
                        Console.Write("9 - дев'ять");
                        break;
                    }
                default:
                    {
                        Console.Write("Error");
                        break;
                    }
            }

         }
        else
        {
            Console.Write("Введено невірне число");
        }
    }
}
