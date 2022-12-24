uint valueN = 0;

Console.Write("Enter the value: ");
if (!uint.TryParse(Console.ReadLine(), out valueN)) return;

double a = 0, b = 0, c = 0 ;
int factorial(int num)
{
    return num-1<=0? num :num * factorial(num-1); 
}
for (int i = 1; i <= valueN; i++)
{
    a += Math.Pow(-1, i) / (2 * i + 1);
    b += 1 + 1 / (i * i);
    c += factorial(i);
}
Console.WriteLine($"a = { a}\nb = {b}\nc = {c}");