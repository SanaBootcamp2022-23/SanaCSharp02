double suma = 0, a;
Console.WriteLine("Enter 5 marks below to check your acces to exam!");
for(int i = 1; i <= 5; i++)
{
    Console.Write(i + " Mark: ");
    a = double.Parse(Console.ReadLine());
    suma = a + suma;
}
suma /= 5;
if (suma >= 4)
    Console.WriteLine("Take your pan and go to exam :)");
else
    Console.WriteLine("Sorry, u can`t go to exam now :(");