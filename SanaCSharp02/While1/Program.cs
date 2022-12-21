Console.Write("Write n: ");
int n = Convert.ToInt32(Console.ReadLine());
double a = 0;
double b = 0;
double c =0;
int factorial = 1;
for (int i = 0; i < n; i++)
{
    a += (Math.Pow(-1, i +1)) / ((2 * i + 1) + 1);
    b += 1 + (1 / (Math.Pow(i+1, 2)));
    factorial *= i+1;
    c += factorial;

}
Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
