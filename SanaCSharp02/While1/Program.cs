class Program
{
    //static void Main()
    //{
    //    int factorialSum = 0;
    //    for(int j = 1; j <= 5; j++)
    //    {
    //        int temp = 1;
    //        for (int i = 1; i <= j; i++)
    //        {
    //            temp *= i; 
    //        }
    //        factorialSum += temp;
    //    }
    //    Console.WriteLine(factorialSum);
    //}




    static void Main()
    {
        Console.Write("n: ");
        int n = Int32.Parse(Console.ReadLine());

        int counter = n;

        double resultA = 0;
        double resultB = 0;
        int resultC = 0;
        while (counter != 0)
        {
            resultA += (Math.Pow(-1, counter)) / (2 * counter + 1);
            resultB += 1 + 1/Math.Pow(counter, 2);

            int counter2 = counter;
            int temp = 1;
            while(counter2 >= 1)
            {
                temp *= counter2;
                counter2 --;
            }
            resultC += temp;
            counter--;
        }
        Console.WriteLine("a: "+ resultA + "\t"+ "b: " + resultB + "\t"+ "c: " + resultC);
    }
}