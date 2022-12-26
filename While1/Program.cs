using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int n;
Console.Write("Введіть n: ");
CheckValue(Console.ReadLine(), out n);

float a = 0, b = 0, c = 0;
int count = 1;
while(count <= n)
{
    a += (float)Math.Pow(-1, count) / (2 * count + 1);
    b += 1 + 1 / ((float)count * count);
    c += getFactorial(count);
    count++;
}
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.ReadKey();



int getFactorial(int a)
{
    int fact = 1;
    for(int i = 1; i<=a; i++)
    {
        fact *= i;
    }
    return fact;
}
void CheckValue(string? s, out int a)
{
    bool fl = false;
    do
    {
        if (!int.TryParse(s, out a))
        {
            Console.Write("\tПомилка!\nПеревірте введені значення та повторіть введення: ");
            s = Console.ReadLine();
        }
        else
        {
            fl = true;
        }
    } while (!fl);
}