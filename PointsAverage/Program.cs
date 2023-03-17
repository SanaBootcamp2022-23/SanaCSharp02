int[] points = new int[5];
int sum = 0, avg;
Console.WriteLine("input");
for (int i = 0; i < 5; i++)
{
    Console.Write(":");
    points[i] = Convert.ToInt32(Console.ReadLine());
    sum = sum + points[i];
}
avg = sum/5;
if (avg>=4)
    Console.WriteLine("pass");
else 
    Console.WriteLine("did not pass");
