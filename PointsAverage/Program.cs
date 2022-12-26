// See https://aka.ms/new-console-template for more information
double avrMark = 0;
int sumMark = 0;
Console.WriteLine("Please, enter grade mark from 1 to 5");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"grade mark {i}");
    int mark = enterData();
    sumMark = sumMark + mark;
}
avrMark = sumMark / 5;
if(avrMark >= 4)
{
    Console.WriteLine("You are allowed, welcome");
}
else
{
    Console.WriteLine("It`s a pity, but you`re not allowed");
}

int enterData()
{
    string consoleString = Console.ReadLine();
    return int.Parse(consoleString);
}
