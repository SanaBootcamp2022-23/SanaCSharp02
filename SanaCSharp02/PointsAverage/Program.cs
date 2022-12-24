using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
int pointsSum=0;
string str;
for (int i = 1; i <= 5; i++)
{
    switch (i)
    {
        case 1: str = "шу"; break;
        case 2: str = "гу"; break;
        case 3: str = "тю"; break;
        default: str = "ту";break;

    }
    Console.Write($"Введіть {i}-{str} оцінку: ");
    pointsSum += int.Parse(Console.ReadLine());
}
int avarage = pointsSum / 5;
string result = (avarage >= 4) ? "Студент допущений " :"Студент не допущений";
Console.Write(result);