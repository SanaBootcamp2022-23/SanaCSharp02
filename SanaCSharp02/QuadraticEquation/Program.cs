namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            double a,b,c,descriminant;
            Console.Write("Введіть значення a :"); a = double.Parse((Console.ReadLine()));
            Console.Write("Введіть значення b :"); b = double.Parse((Console.ReadLine()));
            Console.Write("Введіть значення c :"); c = double.Parse((Console.ReadLine()));
            descriminant = b * b - 4 * a * c;
            if(descriminant < 0) 
            {
                Console.WriteLine("Дискримінант = {0},коренів немає.", descriminant);
            }else if (descriminant > 0) 
            {
                Console.WriteLine("Дискримінант = {0}.Перший корень = {1} , другий = {2}", descriminant,(-b+Math.Sqrt(descriminant) )/(2*a), (-b - Math.Sqrt(descriminant)) / (2 * a));

            }
            else 
            {
                Console.WriteLine("Дискримінант = {0}.Корень = {1}", descriminant, (-b) / (2 * a));

            }
        }
    }
}