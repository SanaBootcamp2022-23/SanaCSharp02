
int number;
double firstEquation = 0, secondEquation = 0, thirdEquation = 0;

CheckAndWriteNumber(out number);

for (int i = 1; i <= number; i++)
{
    firstEquation += (Math.Pow(-1, i) / (2 * i + 1));
    secondEquation += (1 + (1 / Math.Pow(i, 2)));
    int tmpOfThirdEquation = 1;
    for (int j = 1; j <= i; j++)
    {
        tmpOfThirdEquation *= j;
    }
    thirdEquation += tmpOfThirdEquation;
}

Console.WriteLine($"a = {firstEquation}\nb = {secondEquation}\nc = {thirdEquation}");

void CheckAndWriteNumber(out int number)
{
    bool isRightNumber;
    do
    {
        Console.Write($"Input number: ");
        isRightNumber = int.TryParse(Console.ReadLine(), out number);
        if (number <= 0)
            isRightNumber = false;
        if (!isRightNumber)
        {
            Console.Write("ERROR!!!\n");
        }
    } while (!isRightNumber);
}