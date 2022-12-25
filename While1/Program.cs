using System.Text;
using System.Xml.Linq;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
int n;
double a = 0, b = 0, c = 0;

int enternubmer(string name, out int nubmer)
{
    Console.Write($"Введiть число {name}: ");
    while (!int.TryParse(Console.ReadLine(), out nubmer) || !(nubmer>0))
    {
        Console.Write($"Невірно введенно число {name}, введіть ще раз число {name}: ");
    }
    return nubmer;
}
n = enternubmer("n", out n);

for (int i = 1; i <= n; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + (1 / Math.Pow(i, 2));
    double factorial = 1;
    for (int j = 1; j <= i; j++)
    {
        factorial *= j;
    }
    c += factorial;
}


Console.Write($"Число a = {a}\nЧисло b = {b}\nЧисло c = {c}");