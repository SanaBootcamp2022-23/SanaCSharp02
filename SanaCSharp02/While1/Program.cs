double n = 0, i = 1, a = 0, b = 0, c = 0, fact = 1;

Console.Write("Input n:");
n = double.Parse(Console.ReadLine());

while (i <= n) 
{
    a += Math.Pow(-1, i) / ((i * 2) + 1);
    b += 1 + (1/Math.Pow(i,2));
    fact = fact * i;
    c += fact;
    i++;
}
Console.WriteLine($" a = {a}\n b = {b}\n c = {c}\n");