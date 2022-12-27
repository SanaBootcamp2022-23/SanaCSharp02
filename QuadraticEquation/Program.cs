using System;

double a, b, c;


Console.Write("a:");
a = double.Parse(Console.ReadLine());

Console.Write("b:");
b = double.Parse(Console.ReadLine());

Console.Write("c:");
c = double.Parse(Console.ReadLine());


double dis = Math.Pow(b, 2) - 4*a*c;
Console.WriteLine("Дискримінант = {0}:",dis);

double x1 = (-b+ Math.Sqrt(dis))/2*a;
double x2 = (-b- Math.Sqrt(dis))/2*a;
double x = (-b) / 2 * a;

if (dis == 0) 
{
    Console.WriteLine("x={0}", x);
}

else if (dis <0)
{
    Console.WriteLine("Рівняння не має розв'язків.");
}
else 
{
    Console.Write("x1={0}",x1);
    Console.Write("x2={0}",x2);
}








