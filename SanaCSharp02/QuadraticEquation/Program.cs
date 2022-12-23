// See https://aka.ms/new-console-template for more information

double inputA;
double inputB;
double inputC;
double discriminant = 0;
double resultX1;
double resultX2;

Console.Write("a = ");
inputA= double.Parse(Console.ReadLine());

Console.Write("b = ");
inputB = double.Parse(Console.ReadLine());

Console.Write("c = ");
inputC = double.Parse(Console.ReadLine());

if (inputA != 0)
{
    discriminant = (double)Math.Pow(inputB, 2) - 4 * inputA * inputC;
    Console.WriteLine($"Discriminant = {discriminant}");
}

else
    Console.WriteLine("This equation is not quadratic");

switch (discriminant)
{
    case < 0:
        Console.WriteLine("This quadratic equation hasn't roots");
        break;
    
    case 0:
        resultX1 = (-inputB - Math.Sqrt(discriminant)) /(2 * inputA);
        Console.WriteLine($"X = {resultX1}");
        break;
    
    case > 0:
        resultX1 = (-inputB + Math.Sqrt(discriminant)) / (2 * inputA);
        resultX2 = (-inputB - Math.Sqrt(discriminant)) / (2 * inputA);
        Console.WriteLine($"X1 = {resultX1}");
        Console.WriteLine($"X2 = {resultX2}");
        break;
}