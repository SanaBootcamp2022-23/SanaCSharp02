using System.Runtime.CompilerServices;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

float a, b, c;
Console.Write("Введіть а: ");
CheckValuesIsFloat(Console.ReadLine(), out a);
Console.Write("Введіть b: ");
CheckValuesIsFloat(Console.ReadLine(), out b);
Console.Write("Введіть c: ");
CheckValuesIsFloat(Console.ReadLine(), out c);

float d = b * b - 4 * a * c;

if (d < 0)
{
    Console.WriteLine("Розв'язків немає!");
}
else if(d == 0)
{
    Console.WriteLine($"x = {-b / (2 * a)}");
}
else
{
    Console.WriteLine($"x1 = {(-b - Math.Sqrt(d)) / (2 * a)}\nx2 = {(-b + Math.Sqrt(d)) / (2 * a)}");
}
Console.ReadKey();



void CheckValuesIsFloat(string? s, out float a)
{
    bool fl = false;
    do
    {
        if (!float.TryParse(s, out a))
        {
            Console.WriteLine("\tПомилка! Перевірте введені значення та повторіть введення!");
            s = Console.ReadLine();
        }
        else
        {
            fl = true;
        }
    } while (!fl);
}
