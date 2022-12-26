using System.Runtime.CompilerServices;

double a,b,c,d,x1,x2;
Console.WriteLine("Program for calculating square expressions");

a = enterData("Please enter coefficient a");
b = enterData("Please enter coefficient b");
c = enterData("Please enter coefficient c");

double discriminantCalculate(double a, double b, double c)
{
    return Math.Pow(b, 2) - 4 * a * c;
}

d = discriminantCalculate(a,b,c);

if (d > 0)
{
    x1 = (-b + Math.Sqrt(d)) / 2 * a;
    x2 = (-b - Math.Sqrt(d)) / 2 * a;
    outResult("Equation has two roots, `cause discriminant is positive and bigger than 0. D = ",d);
    outResult("x1 = ",x1);
    outResult("x2 = ",x2);
}
else if (d == 0)
{
    x1 = (-b - Math.Sqrt(c)) / 2 * a;
    outResult("Equation has one root, `cause discriminant equals 0. D = ", d);
    outResult("x1 = x2 = ", x1);
}
else
{
    outResult("Equation has no roots,`cause discriminant less than 0. D = ", d);
}

void outResult(string s, double x)
{
    Console.WriteLine(s + x);
}

double enterData(String s)
{
    
    Console.WriteLine(s);
    string consoleString = Console.ReadLine();
    return double.Parse(consoleString);
}