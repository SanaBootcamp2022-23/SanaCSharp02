int point = 0;
double avg;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Enter point #{i + 1}");
    point += Convert.ToInt32(Console.ReadLine());
}

avg = point / 5.0;
if (avg >= 4)
{
    Console.WriteLine($"Avg point {avg}\nStudent is admitted ");
}
else
{
    Console.WriteLine($"Avg point {avg}\nStudent isn't admitted");
}