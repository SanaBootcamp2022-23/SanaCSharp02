int n;
double taskA = 0;
double taskB = 0;
double taskC = 0;
double factorial = 1;
Console.Write("Будь ласка, введiть натуральне число n: ");
n = Convert.ToInt16(Console.ReadLine());

int i = 1;

while (i <= n)
{
    taskA += Math.Pow(-1.0, n) / (2.0 * n + 1);
    taskB += (1 + 1.0 / Math.Pow(n, 2));
    factorial *= i;
    taskC += factorial;
    i++;
}

Console.WriteLine($"а = {taskA}");
Console.WriteLine($"b = {taskB}");
Console.WriteLine($"c = {taskC}");

Console.ReadLine(); //щоб консоль не закривалася відразу