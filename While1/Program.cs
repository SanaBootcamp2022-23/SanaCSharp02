using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = UTF8Encoding.UTF8;

int Factorial(int i)
{
    int f = 1;
    for(int j = 1; j < i+1; j++)
    f *= j;
    return f;

}

int n;
double a=0,b=0,c=0;
Console.Write("Введіть натуральне число n: ");
n=int.Parse(Console.ReadLine());

if (n < 1) 
    Console.WriteLine("Error");
else
{
    for(int i = 1; i < n+1; i++)
    {
        a += (Math.Pow(-1, i)) / (2 * i + 1);
        b += 1 + (1 / Math.Pow(i, 2));
        c += Factorial(i);
    }
}
Console.WriteLine($" a = {a:F3}");
Console.WriteLine($" b = {b:F3}");
Console.WriteLine($" c = {c:F3}");