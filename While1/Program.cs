using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
uint n;
int factorial=1;
double a = 0, b = 0, c = 0, result;
a = -(1.0 / 3.0) + (1.0 / 5.0);
b = (1 + 1.0 / Math.Pow(1.0, 2.0)) + (1 + 1.0 / Math.Pow(2.0, 2.0));
bool ok;
    do
    {
        Console.Write("Введіть значення n = ");
        ok = uint.TryParse(Console.ReadLine(), out n);
        if (!ok)
            Console.WriteLine("Помилка введення значення n. Будь-ласка повторіть вдення значення ще раз!");
    } while (!ok);

    for (int i = 1; i <= n; i++)
    {
        a += Math.Pow(-1.0, i) / (2.0 * i + 1);
        b += (1 + 1.0 / Math.Pow(i,2));
        factorial *= i;
        c += factorial;
    }


    Console.WriteLine($"a = {a:F2}, b = {b:F2}, c = {c}");

