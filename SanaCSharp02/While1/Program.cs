Console.OutputEncoding = System.Text.Encoding.Default;

// Ввід числа n
Console.WriteLine("Введіть натуральне число n:");
int n = int.Parse(Console.ReadLine());

// Розрахунок суми a
double a = 0;
int i = 0;
    
    while (i <= n)
    {
        a += Math.Pow(-1, i) / (2 * i + 1);
        i++;
    }

// Розрахунок суми b
double b = 0;
i = 0;
    
    while (i <= n)
    {
    b += 1 / Math.Pow(i + 1, 2);
    i++;
    }

// Розрахунок суми c
double c = 0;
i = 0;
    
    while (i <= n)
    {
        c += Factorial(i);
        i++;
    }

// Вивід результатів
Console.WriteLine("a = {0}", Math.Round(a, 2));
Console.WriteLine("b = {0}", Math.Round(b, 2));
Console.WriteLine("c = {0}", Math.Round(c, 2));
        

// Функція для підрахунку факторіала числа n
    static double Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}