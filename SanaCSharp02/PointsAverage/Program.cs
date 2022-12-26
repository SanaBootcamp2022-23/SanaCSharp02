namespace PointsAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.Write("Введіть 5 оцінок студента:");
            double[] array = new double[5];
            double avarage = 0;
            for(int i = 0; i < array.Length; i++) 
            {
                array[i] = double.Parse(Console.ReadLine());
                avarage += array[i];
            }
            avarage /= array.Length;
            Console.WriteLine("{0},його середня оцінка : {1}", avarage > 4 ? "Допущений студент до екзамену" : "Не допущений студент до екзамену", avarage);
        }
    }
}