// See https://aka.ms/new-console-template for more information
internal class Program {
    private static void Main(string[] args){
        int a, b, c;
        double D, x1, x2,x;
        Console.Write("Press A: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Press B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Press C: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine($"Quadratic Equation: {a}x^2+{b}x+{c}=0");
        D = b * b - (4 * a * c);
        Console.WriteLine($"D = {D}");
        if (D == 0){
            x = -b / (2 * a);
            Console.WriteLine($"{x}");
        }
        if (D > 0){
            x1 = (-b + Math.Sqrt(D)) / (2 * a);
            x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"{x1}");
            Console.WriteLine($"{x2}");
        }
        if (D < 0){
            Console.WriteLine("Error! D < 0");
        }
    }
}


