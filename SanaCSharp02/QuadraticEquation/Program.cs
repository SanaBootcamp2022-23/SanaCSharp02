// See https://aka.ms/new-console-template for more information

int inputA, inputB, inputC;
double resultX1, resultX2, resultDiskriminans;

Console.WriteLine("For calculate the quadratic equation please input data:");
Console.Write("a = ");
inputA = int.Parse(Console.ReadLine());
Console.Write("b = ");
inputB = int.Parse(Console.ReadLine());
Console.Write("c = ");
inputC = int.Parse(Console.ReadLine());

if (inputA == 0)
{
    Console.WriteLine("Error! a = 0");
    return;
}
else
{
    resultDiskriminans = Math.Pow(inputB, 2) - 4 * inputA * inputC;
    Console.WriteLine($"Diskriminans = {resultDiskriminans}");
}

if (resultDiskriminans > 0)
{
    resultX1 = (- inputB - Math.Sqrt(resultDiskriminans)) * 1.0 / (2 * inputA);
    resultX2 = (- inputB + Math.Sqrt(resultDiskriminans)) * 1.0 / (2 * inputA);
    Console.WriteLine($"x1 = {resultX1}, x2 = {resultX2}");
}

if (resultDiskriminans == 0)
{
    resultX1 = -inputB * 1.0 / 2 * inputA;
    Console.WriteLine($"x1 = {resultX1}");
}

if (resultDiskriminans < 0)
{
    Console.WriteLine("The equation has no solutions!");
}

