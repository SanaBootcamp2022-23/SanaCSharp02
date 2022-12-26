using System.Security.Cryptography.X509Certificates;
using System.Xml;

int a = 0, b = 0, c = 0;

Console.WriteLine("Intput 'a' variable:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Intput 'b' variable:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Intput 'c' variable:");
c = int.Parse(Console.ReadLine());

int discriminator = (b*b - (4 * a * c));
Console.WriteLine($"Distcriminator: {discriminator}");

if (discriminator == 0)
{
    int x = (-b / (2 * a));
    Console.WriteLine($"Distcriminator = 0");
    Console.WriteLine($"Output {x}");
}
else if(discriminator > 0)
{
    int x1 = (-b + (int)Math.Sqrt(discriminator)) / (2 * a);
    int x2 = (-b - (int)Math.Sqrt(discriminator)) / (2 * a);
    Console.WriteLine($"Distcriminator > 0");
    Console.WriteLine($"Output x1 {x1} and x2 {x2}");
}
else if (discriminator < 0)
{
    Console.WriteLine("Without solution. ^_^");
}
