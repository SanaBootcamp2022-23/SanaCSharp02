Console.OutputEncoding = System.Text.Encoding.Default;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Введіть коефіцієнти через Enter a, b, c:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

// Знаходження дискрімінанту
double discriminant = b * b - 4 * a * c;

// Вирішення рівняння
    if (discriminant > 0)
    {
        // Рівняння має два корені
        double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
        double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine("Рівняння має два корені: x1 = {0}, x2 = {1}", Math.Round(x1, 2), Math.Round(x2, 2));
    }
    else if (discriminant == 0)
    {
        // Рівняння має один корень
        double x = -b / (2 * a);
        Console.WriteLine("Рівняння має один корень: x = {0}", Math.Round(x, 2));
    }
    else
    {
        // Рівняння не має рішень
        Console.WriteLine("Рівняння не має рішень");
    }