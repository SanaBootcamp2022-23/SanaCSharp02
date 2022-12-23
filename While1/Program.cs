using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;


int n = GetNumber();

Console.WriteLine($"A = {SolveA(n)}");
Console.WriteLine($"B = {SolveB(n)}");
Console.WriteLine($"C = {SolveC(n)}");

int GetNumber()
{
    int number;
    do
    {
        Console.WriteLine($"Введіть натуральне число:");
        if (!int.TryParse(Console.ReadLine(), out number))
            Console.WriteLine($"Помилка у введені числа! Спробуйте ще раз. \nВведіть число:");
        else
        {
            Console.WriteLine($"Число записано!\n");
            break;
        }

    } while (true);
    return number;
}

double SolveA(int n)
{
    double sum = 0;
    int i = 1;

    while (i <= n)
    { 
        sum += Math.Pow(-1, i) / (2 * i + 1);
        i++;
    }
    return sum;
}

double SolveB(int n)
{
    double sum = 0;
    int i = 1;

    while (i <= n)
    {
        sum += 1 + 1 / Math.Pow(i, 2);
        i++;
    }
    return sum;
}

double SolveC(int n)
{
    double factorial = 1;
    int i = 2;

    while (i <= n)
    {
        factorial *= i;
        i++;
    }
    return factorial;
}