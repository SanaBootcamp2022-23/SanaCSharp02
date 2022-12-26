internal class Program
{
    private static void Main()
    {
        double a, b, c;

        Console.WriteLine("\nEnter quadratic equation coefficients\n");
        a = ParseDoubleVar(nameof(a));
        b = ParseDoubleVar(nameof(b));
        c = ParseDoubleVar(nameof(c));
        Console.WriteLine("");

        var equation = new QuadraticEquation(a, b, c);
        equation.Solve();
    }

    private static double ParseDoubleVar(string varName)
    {
        bool success;
        double result;

        do
        {
            Console.Write($"Insert value for {varName}: ");
            success = double.TryParse(Console.ReadLine(), out result);

            if (!success)
                Console.WriteLine("\nParsing error, try again");
        } while (!success);

        return result;
    }
}


class QuadraticEquation
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public QuadraticEquation(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public void Solve()
    {
        Action solver =
            A == 0
                ? ZeroASolver
                : DiscriminantSolver;

        solver();
    }

    private void DiscriminantSolver()
    {
        double D = Math.Pow(B, 2) - 4 * A * C;
        Console.WriteLine($"Discriminant: {D:0.000}");

        if (D >= 0)
        {
            if (D == 0)
            {
                double x = -B / 2 * A;
                Console.WriteLine($"x: {x:0.000}");
            }
            else
            {
                double x1, x2;

                x1 = (-B + Math.Sqrt(D)) / (2 * A);
                x2 = (-B - Math.Sqrt(D)) / (2 * A);

                Console.WriteLine($"x1: {x1:0.000}, x2: {x2:0.000}");
            }
        }
        else
        {
            Console.WriteLine("Equation doesn't have solutions");
        }
    }

    private void ZeroASolver()
    {
        if (B == 0)
        {
            Console.WriteLine(
                C == 0
                    ? "Solution of an equation is a set of all real numbers(R)"
                    : "Equation doesn't have solutions"
            );
        }
        else
        {
            double x = -C / B;
            Console.WriteLine($"x: {x:0.000}");
        }
    }
}
