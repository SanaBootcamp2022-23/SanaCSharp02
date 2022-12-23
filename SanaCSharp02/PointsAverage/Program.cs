

Console.WriteLine("Enter 5 points: ");
int[] points = new int[5];
for (int i = 0; i < points.Length; i++)
{
    int a = int.Parse(Console.ReadLine());
    if (a > 5 || a < 0)
    {
        Console.WriteLine("Value only can be between values 1 and 5.");
        i--;
    }
    else
    {
        points[i] = a;
    }
}

if (points.Average() >= 4)
{
    Console.WriteLine($"Student is admitted. Average score: {points.Average()}");
}
else
{
    Console.WriteLine($"Student is not admitted. Average score: {points.Average()}");
}