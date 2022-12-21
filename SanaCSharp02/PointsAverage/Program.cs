int[] studentMarks = new int[5];
int sum = 0;
for (int i = 0; i < studentMarks.Length; i++)
{
    do
        Console.WriteLine($"Input Mark {i + 1} = ");
    while (!(int.TryParse(Console.ReadLine(), out studentMarks[i]) && studentMarks[i] > 0 && studentMarks[i] <= 5));
    sum += studentMarks[i];
}
if (sum / 5 >= 4)
    Console.WriteLine("The student is admitted to the exam");
else
    Console.WriteLine("The student is not admitted to the exam");