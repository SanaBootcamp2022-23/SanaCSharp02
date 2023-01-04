int mark, sum = 0;
double avrg;
for (int i = 1; i <= 5; i++)
{
    Console.Write($"Enter {i} mark: ");
    mark = int.Parse(Console.ReadLine());
    sum += mark;
}

avrg = (double)sum / 5;

if (avrg >= 4)
    Console.WriteLine("Student is admitted");
else
    Console.WriteLine("Student is not admitted");
