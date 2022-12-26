double a1, a2, a3, a4, a5, res;

Console.WriteLine("Enter first mark:");
a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter second mark:");
a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter third mark:");
a3= double.Parse(Console.ReadLine());
Console.WriteLine("Enter fourth mark:");
a4 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter fifth mark:");
a5 = double.Parse(Console.ReadLine());

res = (a1 + a2 + a3 + a4 + a5) / 5;
if (res >= 4)
{
    Console.WriteLine("Допущено!");
}
else
    Console.WriteLine("Недопуск!");