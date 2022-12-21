double a, b, c;
do
    Console.WriteLine("Input a = ");
while (!double.TryParse(Console.ReadLine(), out a));
do
    Console.WriteLine("Input b= ");
while (!double.TryParse(Console.ReadLine(), out b));
do
    Console.WriteLine("Input c= ");
while (!double.TryParse(Console.ReadLine(), out c));
double D=(Math.Pow(b,2)- 4*a*c);
if (D>0)
{
    double x1, x2;
    x1=(-b+Math.Sqrt(D))/(2*a);
    x2=(-b-Math.Sqrt(D))/(2*a);
    Console.WriteLine($"x1= {x1}\nx2= {x2}");
}
else 
    if(D==0)
{
    double x;
    x = -b / (2 * a);
    Console.WriteLine($"x= {x}\n");
}
else
{
    Console.WriteLine("There are no real roots when D < 0.");
}