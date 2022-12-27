int point = 0;
for (int i = 0; i < 5; i++)
{
    int p;
    Console.Write("Enter point: ");
    while (!int.TryParse(Console.ReadLine(), out p))
    {
        Console.Write("Invalid value, Try again: ");
    }
    point += p;
}
point /= 5;
if (point >= 4)
{
    Console.Write($"Admitted to the exam. Avg point: {point}");
}
else
{
    Console.Write($"Not admitted to the exam. Avg point: {point}");
}