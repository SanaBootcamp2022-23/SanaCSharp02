

Console.OutputEncoding = System.Text.Encoding.Default;

Console.Write("Введіть N: ");
int N = Convert.ToInt32(Console.ReadLine());

A(N);
B(N);
C(N);


void A(int n)
{
    double sum = 0;
    int i = 1;

    while (i <= n)
    {
        sum += Math.Pow(-1, i) / (2 * i + 1);
        i++;
    }
    Console.WriteLine(sum);
};

void B(int n)
{
    double sum = 0;
    int i = 1;

    while (i <= n)
    {
        sum += 1 + 1 / Math.Pow(i, 2);
        i++;
    }
    Console.WriteLine(sum);
}

void C(int n)
{
    double factorial = 1;
    int i = 2;

    while (i <= n)
    {
        factorial *= i;
        i++;
    }
    Console.WriteLine(factorial);
};





