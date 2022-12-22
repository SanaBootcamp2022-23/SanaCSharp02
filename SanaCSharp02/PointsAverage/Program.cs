double DoubleInputMark(string text)
{
    bool check = false;
    double val = 0;
    while (!check || val < 1 || val > 5)
    {
        Console.Write(text);
        check = double.TryParse(Console.ReadLine(), out val);
        if (!check || val < 1 || val > 5)
        {
            Console.WriteLine("Incorect input, you must write a mark from 1 to 5.");
        }
    }
    return val;
}

double sum = 0;

for (int i = 0; i < 5; i++)
{
    double tmp = DoubleInputMark($"mark {i + 1} = ");
    sum += tmp;
}

double average = sum / 5;
Console.WriteLine($"\naverage mark is {average}");

if (average > 4)
{
    Console.WriteLine("the student receives admission");
}
else
{
    Console.WriteLine("the student doesn't receive admission");
}