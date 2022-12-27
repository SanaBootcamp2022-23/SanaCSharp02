Console.WriteLine("Average mark");
int i, n, sum = 0;
double avg;

Console.Write("Input marks: \n");
for (i = 1; i <= 5; i++)
{
    Console.Write("Mark {0}: ", i);

    n = Convert.ToInt32(Console.ReadLine());
    sum += n;
}
avg = sum / 5.0;
if (avg > 4)
{
    Console.WriteLine($"Average mark is: {avg}| admission to the exam ");
}
else
{
    Console.WriteLine($"Average mark is: {avg}| non-admission to the exam");
}

