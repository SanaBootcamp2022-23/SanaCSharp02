using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int i, j;
double a = 0, b = 0, c = 0, dob = 1;

Console.Write("Введіть кількість повторення циклу:");
i = int.Parse(Console.ReadLine());

while (i > 0)
{
    a += Math.Pow((-1), i) / (2 * i + 1);

    b += 1 + (1 / Math.Pow(i, 2));

    j = i;
    dob = 1;

    while (j > 1)
    {
        dob *= j;
        j--;
    }

    c += dob;
    i--;

}

Console.Write("\na = {0}", a);
Console.Write("\nb = {0}", b);
Console.Write("\nc = {0}", c);
