using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int number;
double a = 0, b = 0, c = 0;

Console.WriteLine("Для вирішення 3х рівнянь необхідно ввести число \"n\": ");
number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    a += (Math.Pow(-1, i) / (2 * i + 1));
    b += (1 + (1 / Math.Pow(i, 2)));
    int factorial = 1;
    for (int d = 1; d <= i; d++)
    {
        factorial *= d;
    }
    c += factorial;
}

Console.WriteLine($"Відповідь для першого рівняння: a = {a}");
Console.WriteLine($"Відповідь для другого рівняння: b = {b}");
Console.WriteLine($"Відповідь для третього рівняння: c = {c}");

