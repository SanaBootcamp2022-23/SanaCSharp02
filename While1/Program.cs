double n = 0, counter = 1, a = 0, b = 0, c = 0, fact = 1;

Console.Write("Input n:");
n = double.Parse(Console.ReadLine());

while (counter <= n) 
{
    a += Math.Pow(-1, counter) / ((counter * 2) + 1);
    b += 1 + (1/Math.Pow(counter,2));
    fact = fact * counter;
    c += fact;
    counter++;
}
Console.WriteLine($"a = {a} b = {b} c = {c}");


