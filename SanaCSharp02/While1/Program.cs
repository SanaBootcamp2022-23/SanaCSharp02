using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

int num, i, j, l;
double a = 0, b = 0, c = 1;

Console.Write("Введіть кількість повторення циклу:");
num = int.Parse(Console.ReadLine());

i = num;
j = num;
l = num;

while (i > 0)
{
    a += Math.Pow((-1), i) / (2 * i + 1);
    i--;
}

while (j > 0)
{
    b += 1 + (1 / Math.Pow(j, 2));
    j--;
}

while (l > 1)
{
    c *= l;
    l--;
}

Console.Write("\na = {0}", a);
Console.Write("\nb = {0}", b);
Console.Write("\nc = {0}", c);
