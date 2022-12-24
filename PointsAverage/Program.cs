
int point;
double sumPoints = 0;

for (int i = 1; i <= 5; i++)
{
    CheckAndWriteNumber(out point, i);
    sumPoints += point;
}

FindOutAdmittion();


void CheckAndWriteNumber(out int point, int i)
{
    bool isRightNumber;
    do
    {
        Console.Write($"Input {i} point: ");
        isRightNumber = int.TryParse(Console.ReadLine(), out point);
        if (point > 5 || point < 1)
            isRightNumber = false;
        if (!isRightNumber)
        {
            Console.Write("ERROR!!!\n");
        }
    } while (!isRightNumber);
}

void FindOutAdmittion()
{
    if ((sumPoints / 5) >= 4)
    {
        Console.WriteLine("This student is admitted to exam.");
    }
    else
    {
        Console.WriteLine("This student is not admitted to exam.");
    }
}