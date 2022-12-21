int n;
Console.WriteLine("Веддiть число n:");
n=int.Parse(Console.ReadLine());
Console.WriteLine($"Було введено число n = {n}\n");
double suma =0;
double sumb = 0;
double sumc = 0;
int factorial=1;
while (n > 0)
{
    suma += Math.Pow((-1), n) / (2.0 * n + 1);
    sumb +=   (1 + 1.0 / (n * n));
    factorial = 1;
    for (int i = 1; i <= n; i++)
        factorial *= i;
    
    sumc += factorial;
    n--;
}
    Console.WriteLine($"за пiдрахунками а={ suma}\n");
Console.WriteLine($"за пiдрахунками b={sumb}\n");
Console.WriteLine($"за пiдрахунками c={sumc}");