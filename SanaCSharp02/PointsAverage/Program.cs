int value = 0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Enter value {i}:");
    value += int.Parse((Console.ReadLine()));
}
Console.WriteLine($"Average is: {value / 5}");
